using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FP.DevSpace2017.Alexa
{
    public class CustomJsonSerializer : JsonSerializer
    {
        public CustomJsonSerializer()
        {
            this.ContractResolver = new CamelCasePropertyNamesContractResolver();
            this.Formatting = Formatting.Indented;
        }
    }
}
