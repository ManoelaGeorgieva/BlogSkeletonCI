﻿using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno;
using TestStack.Seleno.Configuration;

namespace Blog.UI.Tests
{
    public static class BrowserHost
    {
        public static readonly SelenoHost Instance = new SelenoHost();
        //public static readonly string RootUrl = @"http://demoqa.com/registration/";

        static BrowserHost()
        {
            //Instance.Run("Blog", 60639);
            Instance.Run("Blog", 60634);
        }
    }
}
