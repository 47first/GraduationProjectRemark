
namespace WinFormsApplication.Services.Impl
{
    public class ImageService : IImageService
    {
        private const string IMAGES_RELATIVE_DIRECTORY = "Images";
        private const string DEFAULT_IMAGE_NAME = "default.png";
        private static IImageService _instance;
        private Image _defaultImage;

        private ImageService()
        {
            var imagePath = GetImagePath(DEFAULT_IMAGE_NAME);

            _defaultImage = Image.FromFile(imagePath);
        }

        public static IImageService Instance => _instance ?? (_instance = new ImageService());

        public Image GetImage(string? fileName)
        {
            var imagePath = GetImagePath(fileName);

            if (File.Exists(imagePath))
            {
                return Image.FromFile(imagePath);
            }

            return _defaultImage;
        }

        public IEnumerable<string> GetImagesList()
        {
            var imagesPath = Path.Combine(Environment.CurrentDirectory, IMAGES_RELATIVE_DIRECTORY);

            return Directory.GetFiles(imagesPath).Select(x => x.Substring(imagesPath.Length + 1));
        }

        private string GetImagePath(string? fileName)
        {
            return Path.Combine(Environment.CurrentDirectory, IMAGES_RELATIVE_DIRECTORY, fileName ?? string.Empty);
        }
    }
}
