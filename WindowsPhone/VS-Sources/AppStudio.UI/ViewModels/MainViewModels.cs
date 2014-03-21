using System.Threading.Tasks;
using System.Windows.Input;

using AppStudio.Data;
using AppStudio.Services;

namespace AppStudio
{
    public class MainViewModels : BindableBase
    {
       private AppViewModel _appViewModel;
       private AboutViewModel _aboutViewModel;

        private ViewModelBase _selectedItem = null;

        public MainViewModels()
        {
            _selectedItem = AppViewModel;
        }
 
        public AppViewModel AppViewModel
        {
            get { return _appViewModel ?? (_appViewModel = new AppViewModel()); }
        }
 
        public AboutViewModel AboutViewModel
        {
            get { return _aboutViewModel ?? (_aboutViewModel = new AboutViewModel()); }
        }

        public void SetViewType(ViewTypes viewType)
        {
            AppViewModel.ViewType = viewType;
            AboutViewModel.ViewType = viewType;
        }

        public ViewModelBase SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                SetProperty(ref _selectedItem, value);
                UpdateAppBar();
            }
        }

        public bool IsAppBarVisible
        {
            get
            {
                if (SelectedItem == null || SelectedItem == AppViewModel)
                {
                    return true;
                }
                return SelectedItem != null ? SelectedItem.IsAppBarVisible : false;
            }
        }

        public bool IsLockScreenVisible
        {
            get { return SelectedItem == null || SelectedItem == AppViewModel; }
        }

        public bool IsAboutVisible
        {
            get { return SelectedItem == null || SelectedItem == AppViewModel; }
        }

        public void UpdateAppBar()
        {
            OnPropertyChanged("IsAppBarVisible");
            OnPropertyChanged("IsLockScreenVisible");
            OnPropertyChanged("IsAboutVisible");
        }

        /// <summary>
        /// Load ViewModel items asynchronous
        /// </summary>
        public async Task LoadData(bool isNetworkAvailable)
        {
            var loadTasks = new Task[]
            { 
                AppViewModel.LoadItems(isNetworkAvailable),
                AboutViewModel.LoadItems(isNetworkAvailable),
            };
            await Task.WhenAll(loadTasks);
        }

        //
        //  ViewModel command implementation
        //
        public ICommand AboutCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    NavigationServices.NavigateToPage("AboutThisAppPage");
                });
            }
        }

        public ICommand LockScreenCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    LockScreenServices.SetLockScreen("LockScreenImage.jpg");
                });
            }
        }
    }
}
