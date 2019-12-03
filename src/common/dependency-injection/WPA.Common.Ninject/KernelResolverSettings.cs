using Ninject.Modules;

namespace WPA.Common.Ninject
{
    public class KernelResolverSettings
    {
        public NinjectModule[] NinjectModules { get; private set; }

        public KernelResolverSettings SetNinjectModules(params NinjectModule[] ninjectModules)
        {
            NinjectModules = ninjectModules;
            return this;
        }
    }
}
