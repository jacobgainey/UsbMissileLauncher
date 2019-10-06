using Microsoft.Owin;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Owin;
using System;
using System.IO;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace MissileLauncherServer
{
    public class Startup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
            // file system
            //if (!Directory.Exists("www")) Directory.CreateDirectory("www");

            string root = AppDomain.CurrentDomain.BaseDirectory;
            var physicalFileSystem = new PhysicalFileSystem(Path.Combine(root, "www"));

            // file server options
            var fileServerOptions = new FileServerOptions
            {
                RequestPath = PathString.Empty,
                EnableDefaultFiles = true,
                FileSystem = physicalFileSystem,
                EnableDirectoryBrowsing = true
            };

            fileServerOptions.StaticFileOptions.FileSystem = physicalFileSystem;
            fileServerOptions.StaticFileOptions.ServeUnknownFileTypes = true;
            fileServerOptions.DefaultFilesOptions.DefaultFileNames = new[] { "index.html" };

            // Configure Web API for self-host.
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());
            config.Formatters.JsonFormatter.SerializerSettings =
            new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            // Put it all together
            appBuilder.UseWebApi(config);
            appBuilder.UseFileServer(fileServerOptions);
        }
    }
}