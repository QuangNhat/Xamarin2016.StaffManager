using System.Collections.Generic;
using System.Windows.Input;
using Cirrious.MvvmCross.Plugins.Messenger;
using Cirrious.MvvmCross.ViewModels;
using StaffManager.Core.Services.Collections;
using StaffManager.Core.Services.DataStore;

namespace StaffManager.Core.ViewModels
{
    public class ListViewModel
        : MvxViewModel
    {
        private readonly ICollectionService _collectionService;
        private readonly MvxSubscriptionToken _collectionChangedToken;

        public ListViewModel(ICollectionService collectionService, IMvxMessenger messenger)
        {
            _collectionService = collectionService;
            ReloadList();
            _collectionChangedToken = messenger.Subscribe<CollectionChangedMessage>(OnCollectionChanged);
        }

        private void ReloadList()
        {
            Staffs = _collectionService.All();
        }

        private void OnCollectionChanged(CollectionChangedMessage message)
        {
            ReloadList();
        }

        private List<Staff> _staffs;

        public List<Staff> Staffs
        {
            get { return _staffs; }
            set { _staffs = value; RaisePropertyChanged(() => Staffs); }
        }


        public ICommand ShowDetailCommand
        {
            get
            {
                return new MvxCommand<Staff>(staff => ShowViewModel<DetailViewModel>(new DetailViewModel.Nav() { Id= staff.Id }));
            }
        }
    }
}
