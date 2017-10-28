using System.Collections.Generic;

namespace FP.DevSpace2017.Alexa.Model
{
    public class AlexaResponse
    {
        public AlexaResponse()
        {
            Response = new Response();
            SessionAttributes = new SessionAttributes();
        }

        public string Version { get; set; } = "1.0";

        public Response Response { get; set; }

        public SessionAttributes SessionAttributes { get; set; }
    }
}
