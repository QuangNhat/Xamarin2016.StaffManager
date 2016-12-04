using System.Collections.Generic;
using System.Linq;
using Cirrious.MvvmCross.Plugins.Sqlite;

namespace StaffManager.Core.Services.DataStore
{
    public class Repository : IRepository
    {
        private readonly ISQLiteConnection _connection;

        public Repository(ISQLiteConnectionFactory factory)
        {
            _connection = factory.Create("StaffList.sql");
            _connection.CreateTable<Staff>();
        }

        public List<Staff> All()
        {
            return _connection
                .Table<Staff>()
				.OrderByDescending(x => x.Name)
                .ToList();
        }

        public Staff Latest
        {
            get
            {
                return _connection
                    .Table<Staff>()
                    .OrderByDescending(x => x.WhenUtc)
                    .FirstOrDefault();
            }
        }

        public void Add(Staff staffObj)
        {
            _connection.Insert(staffObj);
        }

        public void Delete(Staff staffObj)
        {
            _connection.Delete(staffObj);
        }

        public void Update(Staff staffObj)
        {
            _connection.Update(staffObj);
        }

        public Staff Get(int id)
        {
            return _connection.Get<Staff>(id);
        }
    }
}
