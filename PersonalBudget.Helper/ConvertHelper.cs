using System;
using System.Globalization;

namespace PersonalBudget.Helper
{
    public class ConvertHelper
    {
        private static readonly Lazy<ConvertHelper> lazy = new Lazy<ConvertHelper>(() => new ConvertHelper());

        public static ConvertHelper Instance
        {
            get { return lazy.Value; }
        }

        public ConvertHelper()
        {
        }

        public int ConvertToInt(string text)
        {
            int result = 0;
            if (int.TryParse(text, out result))
            {
                return result;
            }
            return result;
        }

        public int? ConvertToIntNullable(string txt)
        {
            int val = 0;
            if (int.TryParse(txt, out val))
            {
                return val;
            }
            else
            {
                return null;
            }
        }
        public Decimal? ConvertToDecimalNullable(string txt)
        {
            decimal val = 0;
            if (decimal.TryParse(txt, out val))
            {
                return val;
            }
            else
            {
                return null;
            }
        }

        public Decimal? ConvertToDecimalScientificNullable(string txt)
        {
            decimal? val = 0;
            try
            {
                val = Decimal.Parse(txt, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint);
            }
            catch (Exception)
            {
                val = null;
            }
            return val;
        }

        public Decimal ConvertToDecimal(string txt)
        {
            decimal result = 0;

            if (decimal.TryParse(txt, out result))
            {
                return result;
            }
            return result;
        }

        public long? ConvertToLongNullable(string txt)
        {
            if (long.TryParse(txt, out var result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public long ConvertToLong(string txt)
        {
            long val = 0;

            if (long.TryParse(txt, out val))
            {
                return val;
            }
            return val;
        }

        public DateTime? ConvertToDateTimeNullable(string txt)
        {
            DateTime val;
            if (DateTime.TryParse(txt, out val))
            {
                return val;
            }
            else
            {
                return null;
            }
        }
    }
}
