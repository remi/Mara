﻿using System;
using Mara.Drivers;

namespace Mara {

    // Selenium-WebDriver implementation of IMara
    public class WebDriver : IDriver {

        public void ResetSession() {
            throw new NotImplementedException();
        }

        public void Visit(string path) {
            throw new NotImplementedException();
        }

        public string Body {
            get { throw new NotImplementedException(); }
        }

        public string CurrentUrl {
            get { throw new NotImplementedException(); }
        }

        public string CurrentPath {
            get { throw new NotImplementedException(); }
        }
    }
}