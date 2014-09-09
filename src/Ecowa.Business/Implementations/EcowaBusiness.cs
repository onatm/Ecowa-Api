using System;

namespace Ecowa.Business
{
    public class EcowaBusiness : IEcowaBusiness
    {
        public ICategoryService Categories { get; private set; }

        public EcowaBusiness(ICategoryService categoryService)
        {
            Categories = categoryService;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
