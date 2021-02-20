using Ninject.Modules;
using NLayerApp.BL.Services;
using NLayerApp.BL.Interfaces;

namespace NLayerApp.WEB.Util
{
    public class OrderModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IOrderService>().To<OrderService>();
        }
    }
}