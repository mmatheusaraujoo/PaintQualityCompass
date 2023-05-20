using Dapper.Contrib.Extensions;
using Microsoft.Data.Sqlite;

namespace PaintQualityCompass.Repositories
{

    public class Repository<TModel> where TModel : class
    {
        private readonly SqliteConnection _connection;

        public Repository(SqliteConnection connection)
            => _connection = connection;

        public IEnumerable<TModel> GetAll() => _connection.GetAll<TModel>();
        public TModel GetById(int id) => _connection.Get<TModel>(id);
        public void Create(TModel model) => _connection.Insert<TModel>(model);
        public void Update(TModel model) => _connection.Update<TModel>(model);
        public void Delete(TModel model) => _connection.Delete<TModel>(model);
        public void Delete(int id)
        {
            var model = this.GetById(id);
            _connection.Delete<TModel>(model);
        }
    }
}