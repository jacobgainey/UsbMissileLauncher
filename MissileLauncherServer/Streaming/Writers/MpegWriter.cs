using System;
using System.IO;
using System.Net.Sockets;

namespace MissileLauncherServer.Streaming.Writers
{
    public class MpegWriter : System.IDisposable
    {
        public MpegWriter(Stream stream) : this(stream, "--boundary")
        {
        }

        public MpegWriter(Stream stream, string boundary)
        {
            Stream = stream;
            Boundary = boundary;
        }

        public string Boundary { get; private set; }
        public Stream Stream { get; private set; }

        public void WriteHeader()
        {
            Write("HTTP/1.1 200 OK\r\nContent-Type: multipart/x-mixed-replace; boundary=" + Boundary + "\r\n");
            Stream.Flush();
        }

        public void Write(System.Drawing.Image image)
        {
            MemoryStream ms = BytesOf(image);
            Write(ms);
        }

        public void Write(System.IO.MemoryStream imageStream)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.AppendLine();
            sb.AppendLine(Boundary);
            sb.AppendLine("Content-Type: image/jpeg");
            sb.AppendLine("Content-Length: " + imageStream.Length);
            sb.AppendLine();
            Write(sb.ToString());
            imageStream.WriteTo(Stream);
            Write("\r\n");

            Stream.Flush();
        }

        private void Write(byte[] data)
        {
            Stream.Write(data, 0, data.Length);
        }

        private void Write(string text)
        {
            try
            {
                byte[] data = BytesOf(text);
                Stream.Write(data, 0, data.Length);
            }

            catch (Exception)
            {
                throw new SocketException();
            }
        }

        private static byte[] BytesOf(string text)
        {
            return System.Text.Encoding.ASCII.GetBytes(text);
        }

        private static MemoryStream BytesOf(System.Drawing.Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms;
        }

        public string ReadRequest(int length)
        {
            byte[] data = new byte[length];
            int count = Stream.Read(data, 0, data.Length);

            return count != 0 ? System.Text.Encoding.ASCII.GetString(data, 0, count) : null;
        }

        public void Dispose()
        {
            try
            {
                Stream?.Dispose();
            }
            finally
            {
                Stream = null;
            }
        }
    }
}