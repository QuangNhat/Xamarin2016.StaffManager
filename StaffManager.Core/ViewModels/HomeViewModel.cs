using Cirrious.MvvmCross.Plugins.Messenger;
using Cirrious.MvvmCross.ViewModels;
using StaffManager.Core.Services.Collections;
using StaffManager.Core.Services.DataStore;

namespace StaffManager.Core.ViewModels
{
    public class HomeViewModel 
		: MvxViewModel
    {
        private readonly ICollectionService _collectionService;
        private MvxSubscriptionToken _collectionChangedSubscriptionToken;

        public HomeViewModel(ICollectionService collectionService, IMvxMessenger messenger)
        {
            _collectionService = collectionService;
            _collectionChangedSubscriptionToken = messenger.Subscribe<CollectionChangedMessage>(OnCollectionChanged);
            UpdateLatest();
        }

        private void OnCollectionChanged(CollectionChangedMessage obj)
        {
            UpdateLatest();
        }

        private void UpdateLatest()
        {
            Latest = _collectionService.Latest;
			NumOfStaffs = _collectionService.All().Count;
        }

        private Staff _latest;
        public Staff Latest
        {
            get { return _latest; }
            set { _latest = value; RaisePropertyChanged(() => Latest); }
        }

		private int _numOfStaffs;
		public int NumOfStaffs
		{
			get { return _numOfStaffs; }
			set { _numOfStaffs = value; RaisePropertyChanged(() => NumOfStaffs); }
		}

        private Cirrious.MvvmCross.ViewModels.MvxCommand _addCommnad;
        public System.Windows.Input.ICommand AddCommand
        {
            get
            {
                _addCommnad = _addCommnad ?? new Cirrious.MvvmCross.ViewModels.MvxCommand(DoAdd);
                return _addCommnad;
            }
        }

        private void DoAdd()
        {
            ShowViewModel<AddViewModel>();
        }

        private Cirrious.MvvmCross.ViewModels.MvxCommand _listCommand;

        public System.Windows.Input.ICommand ListCommand
        {
            get
            {
                _listCommand = _listCommand ?? new Cirrious.MvvmCross.ViewModels.MvxCommand(DoList);
                return _listCommand;
            }
        }

        private void DoList()
        {
            ShowViewModel<ListViewModel>();
        }                
    }
}
