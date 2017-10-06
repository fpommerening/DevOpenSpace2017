using System;
using FP.DevSpace2017.Alexa.Model;
using Nancy;
using Nancy.ModelBinding;

namespace FP.DevSpace2017.Alexa.Module
{
    public class AlexaModule : NancyModule
    {
        public AlexaModule()
        {
            Post("/", async (args, ct) =>
            {
                var request = this.Bind<AlexaRequest>();
                var response = new AlexaResponse();
                response.Response.OutputSpeech = new OutputSpeech
                {
                    Type = "PlainText",
                    Text = $"Hallo jetzt mit dynamischen Inhalt {DateTime.Now}"
                };
                
                return Response.AsJson(response);
            });
        }
    }
}