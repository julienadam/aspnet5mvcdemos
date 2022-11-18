using System.Globalization;
using System.Resources;
using System.Web.Compilation;

namespace i8nDemo.Plumbing
{
    public class ResourceProvider : IResourceProvider
    {
        public IResourceReader ResourceReader => null;

        public object GetObject(string resourceKey, CultureInfo culture)
        {
            if (culture.LCID == 1025) //1025 - Arabic
                return "مرحبا";
            else if (culture.LCID == 1036) //1036 - French
                return "Bonjour";
            else if (culture.LCID == 1081) //1081 - Hindi
                return "नमस्ते";
            return "Hello";
        }
    }
}