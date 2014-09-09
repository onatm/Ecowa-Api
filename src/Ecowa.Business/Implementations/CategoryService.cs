using AutoMapper;
using Ecowa.Data;
using Ecowa.Model;
using MongoDB.Bson;
using System;

namespace Ecowa.Business
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _repository;

        private IMappingEngine _mapper;

        public CategoryService(ICategoryRepository repository, IMappingEngine mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public CategoryViewModel GetById(string id)
        {
            ObjectId objectId = new ObjectId(id);

            CategoryEntity entity = _repository.GetById(objectId);

            CategoryViewModel model = _mapper.Map<CategoryEntity, CategoryViewModel>(entity);

            return model;
        }

        public CategoryViewModel Add(CategoryViewModel model)
        {
            CategoryEntity entity = _mapper.Map<CategoryViewModel, CategoryEntity>(model);

            CategoryEntity createdEntity = _repository.Add(entity);

            CategoryViewModel createdModel = _mapper.Map<CategoryEntity, CategoryViewModel>(createdEntity);

            return createdModel;
        }

        public CategoryViewModel Update(CategoryViewModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            ObjectId objectId = new ObjectId(id);

            _repository.Delete(objectId);
        }

        public void Delete(CategoryViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
