namespace FP.DevSpace2017.BuildOutside.Module
{
    public class HomeModule : Nancy.NancyModule
    {
        public HomeModule()
        {
            Get("/", args => $"Hallo Usergroup - {DateTime.Now}");
        }
    }
}