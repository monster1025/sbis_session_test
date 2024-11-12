using Newtonsoft.Json.Converters;

namespace SbisApiApp.SbisClient.Converters
{
    public sealed class DateTimeConverter : IsoDateTimeConverter
    {
        public DateTimeConverter()
        {
            DateTimeFormat = "dd.MM.yyyy HH.mm.ss";
        }

        public DateTimeConverter(string format)
        {
            DateTimeFormat = format;
        }
    }
}
