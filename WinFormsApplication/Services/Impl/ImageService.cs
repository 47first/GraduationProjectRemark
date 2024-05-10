
namespace WinFormsApplication.Services.Impl
{
    public class ImageService : IImageService
    {
        private const string IMAGES_RELATIVE_DIRECTORY = "Images";
        private const string DEFAULT_IMAGE_NAME = "default.png";
        private static IImageService _instance;
        private Dictionary<string, Image> _imageCache = new();
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

            if (_imageCache.ContainsKey(imagePath))
            {
                return _imageCache[imagePath];
            }

            if (File.Exists(imagePath))
            {
                var image = Image.FromFile(imagePath);

                _imageCache.Add(imagePath, image);

                return image;
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
