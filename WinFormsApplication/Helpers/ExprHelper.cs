using System.Text.RegularExpressions;

namespace WinFormsApplication.Helpers
{
    public static class ExprHelper
    {
        private static Regex _phoneRegex = new Regex("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$", RegexOptions.Compiled);
        private static Regex _emailRegex = new Regex("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", RegexOptions.Compiled);

        public static Func<bool> StringLength(TextBox input, int minLength, int maxLength)
        {
            return () => input.Text.Length > minLength && input.Text.Length < maxLength;
        }

        public static Func<bool> NullableStringLength(TextBox input, int maxLength)
        {
            return () => string.IsNullOrEmpty(input.Text) || input.Text.Length < maxLength;
        }

        public static Func<bool> PhoneExpr(TextBox phoneInput)
        {
            return () => _phoneRegex.IsMatch(phoneInput.Text);
        }

        public static Func<bool> EmailExpr(TextBox emailInput)
        {
            return () => _emailRegex.IsMatch(emailInput.Text);
        }

    }
}
