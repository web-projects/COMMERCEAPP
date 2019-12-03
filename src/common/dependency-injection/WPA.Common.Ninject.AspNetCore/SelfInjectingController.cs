using Microsoft.AspNetCore.Mvc;

namespace WPA.Common.Ninject.AspNetCore
{
    public class SelfInjectingController : ControllerBase
    {
        public SelfInjectingController()
        {
            NinjectServiceProxy.LocalKernel.Inject(this);
        }
    }
}
