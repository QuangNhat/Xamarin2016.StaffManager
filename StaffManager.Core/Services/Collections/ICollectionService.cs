using System.Collections.Generic;
using StaffManager.Core.Services.DataStore;

namespace StaffManager.Core.Services.Collections
{
    public interface ICollectionService
    {
        List<Staff> All();
        Staff Latest { get; }
        Staff Get(int id);
        void Add(Staff staffObj);
        void Delete(Staff staffObj);
    }
}