namespace WinFormsApplication.Services
{
    public interface IImageService
    {
        public IEnumerable<string> GetImagesList();

        public Image GetImage(string? fileName);

        public string SaveImage(string fullPath);
    }
}
