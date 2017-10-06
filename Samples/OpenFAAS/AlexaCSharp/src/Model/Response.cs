using System;
using System.Collections.Generic;
using System.Text;

namespace FP.DevSpace2017.Alexa.Model
{
    public class Response
    {
        public OutputSpeech OutputSpeech { get; set; }

        public bool ShouldEndSession { get; set; } = true;
    }
}
