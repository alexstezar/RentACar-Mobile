using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using RentACar_Mobile_.Models;

namespace RentACar_Mobile_.Data
{
    public class CarDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public CarDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Car>().Wait();
        }

        public Task<List<Car>> GetCarsAsync()
        {
            return _database.Table<Car>().ToListAsync();
        }

        public Task<Car> GetCarAsync(int  id)
        {
            return _database.Table<Car>()
                .Where(i => i.ID == id)
                .FirstOrDefaultAsync();
        }

        public Task<int> SaveCarAsync(Car favcar)
        {
            if(favcar.ID != 0)
            {
                return _database.UpdateAsync(favcar);
            }
            else
            {
                return _database.InsertAsync(favcar);
            }
        }

        public Task<int> DeleteCarAsync(Car favcar)
        {
            return _database.DeleteAsync(favcar);
        }
    }
}
