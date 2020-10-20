using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace HappyTravel.Formatters.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Currencies
    {
        NotSpecified = 0,
        USD = 1,
        EUR = 2,
        AED = 3,
        SAR = 4
    }
}