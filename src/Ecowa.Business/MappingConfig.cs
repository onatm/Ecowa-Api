using AutoMapper;
using Ecowa.Data;
using Ecowa.Model;

namespace Ecowa.Business
{
    public class MappingConfig
    {
        public static void RegisterMappings()
        {
            Mapper.CreateMap<CategoryEntity, CategoryViewModel>();
            Mapper.CreateMap<CategoryViewModel, CategoryEntity>();
        }
    }
}
