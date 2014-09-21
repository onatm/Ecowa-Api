using System.Collections.Generic;

namespace Ecowa.Business
{
    public interface IService<TModel, TId>
    {
        IEnumerable<TModel> GetAll();
        TModel GetById(TId id);
        TModel Add(TModel model);
        TModel Update(TModel model);
        void Delete(TId id);
        void Delete(TModel model);
    }
}
