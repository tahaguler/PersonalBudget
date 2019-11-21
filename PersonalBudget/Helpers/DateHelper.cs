using System;

namespace PersonalBudget.Api.Helpers
{
    public class DateHelper
    {
        private static readonly Lazy<DateHelper> lazy = new Lazy<DateHelper>(() => new DateHelper());
        public static DateHelper Instance { get { return lazy.Value; } }
        private DateHelper()
        {
        }

        public DateTime GetCurrentUniversalFormat()
        {
            return ConvertToUniversalFormat(DateTime.Now);
        }

        public DateTime ConvertToUniversalFormat(DateTime date)
        {
            return date.ToUniversalTime();
        }

        public DateTime ConvertToUniversalFormat(string date)
        {
            return Convert.ToDateTime(date).ToUniversalTime();
        }

        public string ConvertToUniversalFormatString(DateTime date)
        {
            return date.ToUniversalTime().ToString("MM/dd/yyyy H:mm:ss zzz");
        }
    }
}
