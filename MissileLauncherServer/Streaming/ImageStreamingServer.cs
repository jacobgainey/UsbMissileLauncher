using MissileLauncherServer.Streaming.Writers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MissileLauncherServer.Streaming
{
    public class ImageStreamingServer : IDisposable
    {
        // camera settings

        public string HostingPort { get; set; } = string.Empty;

        public string Host { get; set; } = string.Empty;
        public string Port { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
        public string User { get; set; } = string.Empty;
        public string Pass { get; set; } = string.Empty;

        private readonly List<Socket> _clients;
        private System.Threading.Thread _thread;

        public ImageStreamingServer(string host, string port, string path, string user, string pass) : this(StreamSource.Snapshots())
        {
            this.Host = host;
            this.Port = port;
            this.Path = path;
            this.User = user;
            this.Pass = pass;

            StreamSource.UrlToApi = $"http://{Host}:{Port}{Path}";
            StreamSource.Username = User;
            StreamSource.Password = Pass;
        }

        public ImageStreamingServer(IEnumerable<Image> imagesSource)
        {
            _clients = new List<Socket>();
            _thread = null;

            ImagesSource = imagesSource;
            Interval = 25;
        }

        public IEnumerable<Image> ImagesSource { get; set; }

        public IEnumerable<Socket> Clients
        {
            get
            {
                lock (_clients)
                {
                    return _clients;
                }
            }
        }

        public int Interval { get; set; }
        public bool IsRunning => (_thread != null && _thread.IsAlive);

        public void Start(int port)
        {
            lock (this)
            {
                _thread = new System.Threading.Thread(ServerThread)
                {
                    IsBackground = true
                };
                _thread.Start(port);
            }
        }

        public void Start()
        {
            Start(8080);
        }

        public void Stop()
        {
            if (!IsRunning)
            {
                return;
            }

            try
            {
                _thread.Join();
                _thread.Abort();
            }
            finally
            {
                lock (_clients)
                {
                    foreach (var s in _clients)
                    {
                        try
                        {
                            s.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    _clients.Clear();
                }

                _thread = null;
            }
        }

        private void ServerThread(object state)
        {
            try
            {
                Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                server.Bind(new IPEndPoint(IPAddress.Any, (int)state));
                server.Listen(10);

                Console.WriteLine($"Server started on port {state}.");

                foreach (Socket client in server.IncomingConnections())
                {
                    System.Threading.ThreadPool.QueueUserWorkItem(ClientThread, client);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Stop();
        }

        private void ClientThread(object client)
        {
            Socket socket = (Socket)client;
            Console.WriteLine($"Client {socket.RemoteEndPoint} connected");
            string clientname = socket.RemoteEndPoint.ToString();

            lock (_clients)
            {
                _clients.Add(socket);
            }

            try
            {
                using (MpegWriter wr = new MpegWriter(new NetworkStream(socket, true)))
                {
                    // Writes the response header to the client.
                    wr.WriteHeader();

                    // Streams the images from the source to the client.
                    foreach (var imgStream in ImagesSource)
                    {
                        if (Interval > 0)
                        {
                            System.Threading.Thread.Sleep(Interval);
                        }

                        wr.Write(imgStream);
                    }
                }
            }
            catch (SocketException)
            {
                Console.WriteLine($"Client {clientname} disconnected");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                lock (_clients)
                {
                    _clients.Remove(socket);
                }
            }
        }

        public void Dispose()
        {
            Stop();
        }
    }

    internal static class SocketExtensions
    {
        public static IEnumerable<Socket> IncomingConnections(this Socket server)
        {
            while (true)
            {
                yield return server.Accept();
            }
        }
    }

    public static class StreamSource
    {
        public static string UrlToApi { get; set; } = "http://10.253.6.10/api/jpeg";
        public static string Username { get; set; } = "root";
        public static string Password { get; set; } = "AG$Adm1n";

        public static Image Image;
        public static Stream Stream;

        public static IEnumerable<Image> Snapshots()
        {
            while (true)
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(UrlToApi);

                string authInfo = Username + ":" + Password;
                authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
                httpWebRequest.Headers["Authorization"] = "Basic " + authInfo;

                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Stream = httpWebResponse.GetResponseStream();
                Image = Image.FromStream(Stream ?? throw new InvalidOperationException());

                yield return (Bitmap)Image;
            }
        }

        internal static IEnumerable<MemoryStream> Streams(this IEnumerable<Image> source)
        {
            MemoryStream ms = new MemoryStream();

            foreach (var img in source)
            {
                ms.SetLength(0);
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                yield return ms;
            }

            ms.Close();
            ms = null;
        }
    }
}