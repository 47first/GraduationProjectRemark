namespace WinFormsApplication.Services.Impl
{
    public class PageAccessor : IPageAccessor
    {
        private static IPageAccessor _instance;

        private PageAccessor()
        {

        }

        public static IPageAccessor Instance => _instance ?? (_instance = new PageAccessor());
    }
}
