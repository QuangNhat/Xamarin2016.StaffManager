using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;
using StaffManager.Core.Services.Collections;
using StaffManager.Core.Services.DataStore;

namespace StaffManager.Core.ViewModels
{
    public class DetailViewModel
        : MvxViewModel
    {
        private readonly ICollectionService _collectionService;
        private Staff _staffObj;

        public DetailViewModel(ICollectionService collectionService)
        {
            _collectionService = collectionService;
        }

        public class Nav
        {
            public int Id { get; set; }
        }

        public void Init(Nav navigation)
        {
            StaffObj = _collectionService.Get(navigation.Id);
        }

        public Staff StaffObj
        {
            get { return _staffObj; }
            set { _staffObj = value; RaisePropertyChanged(() => StaffObj); }
        }

        public ICommand DeleteCommand
        {
            get
            {
                return new MvxCommand(() =>
                    {
                        _collectionService.Delete(StaffObj);
                        Close(this);
                    });
            }
        }
    }
}