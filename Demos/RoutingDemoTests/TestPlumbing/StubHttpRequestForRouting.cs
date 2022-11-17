using System.Collections.Specialized;
using System.Web;

namespace DemoTests
{
    public class StubHttpRequestForRouting : HttpRequestBase
    {
        public StubHttpRequestForRouting(string appPath, string requestUrl)
        {
            ApplicationPath = appPath;
            AppRelativeCurrentExecutionFilePath = requestUrl;
        }

        public override string ApplicationPath { get; }

        public override string AppRelativeCurrentExecutionFilePath { get; }

        public override string PathInfo => "";

        public override NameValueCollection ServerVariables => new NameValueCollection();
    }
}