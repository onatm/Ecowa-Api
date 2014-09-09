namespace Ecowa.Business
{
    public interface IService<TModel, TId>
    {
        TModel GetById(TId id);
        TModel Add(TModel model);
        TModel Update(TModel model);
        void Delete(TId id);
        void Delete(TModel model);
    }
}
