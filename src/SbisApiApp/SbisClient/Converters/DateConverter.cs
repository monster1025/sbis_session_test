using Newtonsoft.Json.Converters;

namespace SbisApiApp.SbisClient.Converters
{
    public sealed class DateConverter : IsoDateTimeConverter
    {
        public DateConverter()
        {
            DateTimeFormat = "dd.MM.yyyy";
        }

        public DateConverter(string format)
        {
            DateTimeFormat = format;
        }
    }
}
