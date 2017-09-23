using System;

namespace test1
{
    public class HomeModule : Nancy.NancyModule
    {
        public HomeModule()
        {
            Get("/", args => $"Hallo Usergroup - {DateTime.Now}");
        }
    }
}