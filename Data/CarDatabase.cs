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
            _database.CreateTableAsync<Dealership>().Wait();
            _database.CreateTableAsync<Collection>().Wait();
        }

        public Task<List<Collection>> GetCollectionAsync()
        {
            return _database.Table<Collection>().ToListAsync();
        }

        public Task<int> SaveCollectionAsync(Collection collection)
        {
            if (collection.ID != 0)
            {
                return _database.UpdateAsync(collection);
            }
            else
            {
                return _database.InsertAsync(collection);
            }
        }

        public Task<List<Dealership>> GetDealershipsAsync() 
        {
            return _database.Table<Dealership>().ToListAsync();
        }

        public Task<int> SaveDealershipAsync(Dealership dealership) 
        {
            if (dealership.ID != 0)
            {
                return _database.UpdateAsync(dealership);
            }
            else
            {
                return _database.InsertAsync(dealership);
            }
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
