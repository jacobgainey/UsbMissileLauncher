using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;

namespace MissileLauncherServer.Controller
{
    public class HomeController : ApiController
    {
        [HttpGet]
        [ActionName("Index")]
        public HttpResponseMessage Index()
        {
            var path = @"D:\index.html";
            var response = new HttpResponseMessage
            {
                Content = new StringContent(File.ReadAllText(path))
            };
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            return response;
        }

        public void Post([FromBody]string value)
        {
        }

    }
}