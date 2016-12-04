using System.Collections.Generic;
using Cirrious.MvvmCross.Plugins.Messenger;
using StaffManager.Core.Services.DataStore;

namespace StaffManager.Core.Services.Collections
{
    public class CollectionService
        : ICollectionService
    {
        private readonly IRepository _repository;
        private readonly IMvxMessenger _messenger;

        public CollectionService(IRepository repository, IMvxMessenger messenger)
        {
            _repository = repository;
            _messenger = messenger;
        }

        public List<Staff> All()
        {
            return _repository.All();
        }

        public Staff Get(int id)
        {
            return _repository.Get(id);
        }

        public void Add(Staff staffObj)
        {
            _repository.Add(staffObj);
            _messenger.Publish(new CollectionChangedMessage(this));
        }

        public void Delete(Staff staffObj)
        {
            _repository.Delete(staffObj);
            _messenger.Publish(new CollectionChangedMessage(this));
        }

        public Staff Latest
        {
            get
            {
                return _repository.Latest;
            }
        }
    }
}
