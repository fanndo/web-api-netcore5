using System.Text.Json;

namespace WebAp.Restful.Config
{
    public class JsonLowercaseNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name) => name.ToLowerInvariant();
    }
}
