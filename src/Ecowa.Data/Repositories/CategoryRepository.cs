using Autofuzz.MongoDB;
using MongoDB.Bson;

namespace Ecowa.Data
{
    public interface ICategoryRepository : IFuzzMongoRepository<CategoryEntity, ObjectId>
    {
    }

    public class CategoryRepository : FuzzMongoRepository<CategoryEntity, ObjectId>, ICategoryRepository
    {
    }
}
