using PaintQualityCompass.Data;
using PaintQualityCompass.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintQualityCompass.Controllers
{
    public class Controller<TModel> where TModel : class
    {
        private Repository<TModel> _repository;
        private readonly DbContext _dbContext;

        public Controller()
        {
            _dbContext = GlobalSettings.dbContext;
            _repository = new Repository<TModel>(_dbContext.sqliteConnection);
        }            
        
        public IEnumerable<TModel> GetAll() => _repository.GetAll();
        public TModel GetById(int id) => _repository.GetById(id);
        public void Create(TModel model) => _repository.Create(model);
        public void Update(TModel model) => _repository.Update(model);
        public void Delete(TModel model) => _repository.Delete(model);
        public void Delete(int id) => _repository.Delete(id);
        
    }
}
