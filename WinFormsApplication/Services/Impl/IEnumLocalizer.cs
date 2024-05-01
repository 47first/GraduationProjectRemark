namespace WinFormsApplication.Services.Impl
{
    public interface IEnumLocalizer
    {
        public string GetLocalizedEnum<T>(T value);
    }
}
