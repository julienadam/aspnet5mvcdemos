using System.Web.Compilation;

namespace i8nDemo.Plumbing
{
    [DesignTimeResourceProviderFactory(typeof(ResourceProviderFactory))]
    public class ResourceProviderFactory : System.Web.Compilation.ResourceProviderFactory
    {
        private readonly ResourceProvider resourceProvider = new ResourceProvider();

        public override IResourceProvider CreateGlobalResourceProvider(string classKey)
        {
            return resourceProvider;
        }

        public override IResourceProvider CreateLocalResourceProvider(string virtualPath)
        {
            return resourceProvider;
        }
    }
}