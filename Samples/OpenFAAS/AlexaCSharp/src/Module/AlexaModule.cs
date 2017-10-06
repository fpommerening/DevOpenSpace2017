using System;
using Nancy.Extensions;
using System.IO;

namespace FP.DevSpace2017.WebApp.Module
{
    public class AlexaModule : Nancy.NancyModule
    {
        private static string cache = string.Empty;


        public AlexaModule()
        {
            Post("/", async (args, ct) =>
            {
                string content;
                
                using (Stream responseStream = this.Request.Body)
                using (StreamReader sr = new StreamReader(responseStream))
                {
                    content = await sr.ReadToEndAsync();
                }
                if(content.ToLowerInvariant().StartsWith("updatecache"))
                {
                    cache = content.Substring(11);
                }

                return cache.TrimStart();
            });
        }
    }
}