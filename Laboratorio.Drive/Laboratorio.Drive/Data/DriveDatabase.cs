using Laboratorio.Drive.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Drive.Data
{
    public class DriveDatabase
    {
        private SQLiteAsyncConnection db;

        public DriveDatabase(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Veiculos>().Wait();
        }

        public Task<List<Veiculos>> ListarAsync()
        {
            return db.Table<Veiculos>().ToListAsync();
        }

        public Task<Veiculos> SelecionarAsync(int id)
        {
            return db.Table<Veiculos>()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
        }

        public Task<int> SalvarAsync(Veiculos veiculo)
        {
            if (veiculo.Id == 0)
                return db.InsertAsync(veiculo);
            else
                return db.UpdateAsync(veiculo);
        }

        public Task<int> ExcluirAsync(Veiculos veiculo)
        {
            return db.DeleteAsync(veiculo);
        }
    }
}
