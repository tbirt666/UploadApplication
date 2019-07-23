using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace UploadApplication.Controllers
{
    public class FileUploadController : ApiController
    {
        public async Task<bool> Upload()
        {
            try
            {
                var fileuploadPath = ConfigurationManager.AppSettings["FileUploadLocation"];

                var provider = new MultipartFormDataStreamProvider(fileuploadPath);
                var content = new StreamContent(HttpContext.Current.Request.GetBufferlessInputStream(true));
                foreach (var header in Request.Content.Headers)
                {
                    content.Headers.TryAddWithoutValidation(header.Key, header.Value);
                }

                await content.ReadAsMultipartAsync(provider);

                return true;
            }
            catch (Exception)
            {
                // todo:  add in exeption logging nlog/log4net or something more advanced
                return false;
            }

        }
    }
}
