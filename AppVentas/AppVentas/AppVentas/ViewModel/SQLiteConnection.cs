using System;
using AppVentas.Model;

namespace AppVentas.ViewModel
{
    internal class SQLiteConnection
    {
        private string dbPath;

        public SQLiteConnection(string dbPath)
        {
            this.dbPath = dbPath;
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void CreateTable<T>()
        {
            throw new NotImplementedException();
        }

        internal int Insert(Ventas ventas)
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<T> Table<T>()
        {
            throw new NotImplementedException();
        }
    }
}