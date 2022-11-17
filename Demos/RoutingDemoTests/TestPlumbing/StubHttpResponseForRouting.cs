using System.Web;

namespace DemoTests
{
    public class StubHttpResponseForRouting : HttpResponseBase
    {
        public override string ApplyAppPathModifier(string virtualPath)
        {
            return virtualPath;
        }
    }
}