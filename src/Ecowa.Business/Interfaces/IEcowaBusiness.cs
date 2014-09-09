using System;

namespace Ecowa.Business
{
    public interface IEcowaBusiness : IDisposable
    {
        ICategoryService Categories { get; }
    }
}
