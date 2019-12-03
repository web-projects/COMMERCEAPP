using Ninject;
using Ninject.Modules;

namespace WPA.Common.Ninject
{
    public sealed class WPADefaultResolver : IKernelModuleResolver
    {
        public IKernel ResolveKernel(params NinjectModule[] modules)
        {
            IKernel kernel = new StandardKernel(modules);
            kernel.Settings.InjectNonPublic = true;
            kernel.Settings.InjectParentPrivateProperties = true;
            return kernel;
        }
    }
}
