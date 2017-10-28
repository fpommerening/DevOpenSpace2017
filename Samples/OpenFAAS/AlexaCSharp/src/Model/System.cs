using System;
using System.Collections.Generic;
using System.Text;

namespace FP.DevSpace2017.Alexa.Model
{
    public class System
    {
        public System()
        {
            Application = new Application();
            User = new User();
        }

        public Application Application { get; set; }

        public User User { get; set; }
    }
}
