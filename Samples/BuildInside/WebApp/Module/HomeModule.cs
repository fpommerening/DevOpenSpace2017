using System;

namespace FP.DevSpace2017.BuildInside.Module
{
    public class HomeModule : Nancy.NancyModule
    {
        public HomeModule()
        {
            Get("/", args => $"Hallo Usergroup - {DateTime.Now}");
        }
    }
}