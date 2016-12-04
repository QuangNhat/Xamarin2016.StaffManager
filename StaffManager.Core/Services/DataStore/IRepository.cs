using System.Collections.Generic;

namespace StaffManager.Core.Services.DataStore
{
    public interface IRepository
    {
        List<Staff> All();
        Staff Latest { get; }
        void Add(Staff staffObj);
        void Delete(Staff staffObj);
        void Update(Staff staffObj);
        Staff Get(int id);
    }
}