using System.Text.RegularExpressions;

namespace WinFormsApplication.Helpers
{
    public static class ExprHelper
    {
        private static Regex _phoneRegex = new Regex("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$", RegexOptions.Compiled);
        private static Regex _emailRegex = new Regex("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", RegexOptions.Compiled);

        public static Func<bool> StringLength(Func<string> getter, int minLength, int maxLength)
        {
            return () => string.IsNullOrEmpty(getter().Trim()) == false && getter().Trim().Length > minLength && getter().Trim().Length < maxLength;
        }

        public static Func<bool> NullableStringLength(Func<string> getter, int maxLength)
        {
            return () => string.IsNullOrEmpty(getter()) || getter().Length < maxLength;
        }

        public static Func<bool> PhoneExpr(Func<string> getter)
        {
            return () => _phoneRegex.IsMatch(getter());
        }

        public static Func<bool> EmailExpr(Func<string> getter)
        {
            return () => _emailRegex.IsMatch(getter());
        }

        public static Func<bool> NumberExpr<T>(Func<T> getter, T min, T max) where T : IComparable
        {
            var value = getter();

            return () => value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
        }
    }
}
