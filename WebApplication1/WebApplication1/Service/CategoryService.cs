using ApplicationCore.Entity;
using ApplicationCore.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inter.Service
{
    public class CategoryService
    {
        private readonly IRepository<Category> _categoryRepo;

        public CategoryService(IRepository<Category> categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }
        public IQueryable<Category> GetAllCategory()
        {
            return _categoryRepo.GetAll();
        }
        public async Task<Category> GetById(int? id)
        {
            var category =await _categoryRepo.GetByIdAsync(id);
            return category;
        }
        public async Task Create(Category category)
        {
            await _categoryRepo.AddAsync(category);
        }
        public async Task Update(Category category)
        {
            await _categoryRepo.UpdateAsync(category);
        }
        public async Task Delete(Category category)
        {
            await _categoryRepo.DeleteAsync(category);
        }
        public bool Any(int id)
        {
            return _categoryRepo.GetById(id) != null ;
        }
    }
}
