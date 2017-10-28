using System;
using System.Collections.Generic;
using System.Text;

namespace FP.DevSpace2017.Alexa.Model
{
    public class Intent
    {
        public Intent()
        {
            Slots = new Slots();
        }

        public string Name { get; set; }

        public Slots Slots { get; set; }
    }
}
