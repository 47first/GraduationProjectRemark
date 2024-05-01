using Database.Enums;

namespace WinFormsApplication.Services.Impl
{
    public class EnumLocalizer : IEnumLocalizer
    {
        private static IEnumLocalizer _instance;

        private EnumLocalizer()
        {
        }

        public static IEnumLocalizer Instance => _instance ?? (_instance = new EnumLocalizer());

        public string GetLocalizedEnum<T>(T value)
        {
            if (value is PaymentType paymentType)
            {
                return paymentType switch
                {
                    PaymentType.OneTime => "Единоразовый",
                    PaymentType.PerHour => "Почасовой",
                    _ => string.Empty
                };
            }

            return string.Empty;
        }
    }
}
