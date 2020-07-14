using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using MobileApp_000.Models;

namespace MobileApp_000.Data
{
    public class TransactionDataBase
    {
        readonly SQLiteAsyncConnection _database;
        public TransactionDataBase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Transaccion>().Wait();
        }
        public Task<List<Transaccion>> GetTransactionsAsync()
        {
            return _database.Table<Transaccion>().ToListAsync();
        }
        public Task<Transaccion> GetTransactionAsync(int id)
        {
            return _database.Table<Transaccion>()
            .Where(i => i.ID == id)
            .FirstOrDefaultAsync();
        }
        public Task<int> SaveTransactionAsync(Transaccion transaccion)
        {
            if (transaccion.ID != 0)
            {
                return _database.UpdateAsync(transaccion);
            }
            else
      {
                return _database.InsertAsync(transaccion);
            }
        }
        public Task<int> DeleteTransactionAsync(Transaccion transaccion)
        {
            return _database.DeleteAsync(transaccion);
        }
    }
}
