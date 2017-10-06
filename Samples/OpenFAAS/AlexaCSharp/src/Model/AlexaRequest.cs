using System;

namespace FP.DevSpace2017.Alexa.Model
{
    [Serializable]
    public class AlexaRequest
    {
        public Session Session { get; set; }

        public string Version { get; set; }
    }
}
