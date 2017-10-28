﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FP.DevSpace2017.Alexa.Model
{
    [Serializable]
    public class Session
    {
        public Session()
        {
            Attributes = new SessionAttributes();
            User = new User();
        }

        public bool New { get; set; }

        public string SessionId { get; set; }

        public SessionAttributes Attributes { get; set; }

        public User User { get; set; }
    }
}
