using Ninject;
using Ninject.Modules;

namespace WPA.Common.Ninject
{
    public interface IKernelModuleResolver
    {
        IKernel ResolveKernel(params NinjectModule[] modules);
    }
}
