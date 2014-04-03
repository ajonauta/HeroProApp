using System.Threading.Tasks;
using System.Windows.Input;

using AppStudio.Data;
using AppStudio.Services;

namespace AppStudio
{
    public class MainViewModels : BindableBase
    {
       private AppViewModel _appModel;
       private GoProVODViewModel _goProVODModel;
       private GPTipsTricksViewModel _gPTipsTricksModel;
       private GoProPhotosViewModel _goProPhotosModel;
       private GoProMountsViewModel _goProMountsModel;
       private AboutViewModel _aboutModel;

        private ViewModelBase _selectedItem = null;

        public MainViewModels()
        {
            _selectedItem = AppModel;
        }
 
        public AppViewModel AppModel
        {
            get { return _appModel ?? (_appModel = new AppViewModel()); }
        }
 
        public GoProVODViewModel GoProVODModel
        {
            get { return _goProVODModel ?? (_goProVODModel = new GoProVODViewModel()); }
        }
 
        public GPTipsTricksViewModel GPTipsTricksModel
        {
            get { return _gPTipsTricksModel ?? (_gPTipsTricksModel = new GPTipsTricksViewModel()); }
        }
 
        public GoProPhotosViewModel GoProPhotosModel
        {
            get { return _goProPhotosModel ?? (_goProPhotosModel = new GoProPhotosViewModel()); }
        }
 
        public GoProMountsViewModel GoProMountsModel
        {
            get { return _goProMountsModel ?? (_goProMountsModel = new GoProMountsViewModel()); }
        }
 
        public AboutViewModel AboutModel
        {
            get { return _aboutModel ?? (_aboutModel = new AboutViewModel()); }
        }

        public void SetViewType(ViewTypes viewType)
        {
            AppModel.ViewType = viewType;
            GoProVODModel.ViewType = viewType;
            GPTipsTricksModel.ViewType = viewType;
            GoProPhotosModel.ViewType = viewType;
            GoProMountsModel.ViewType = viewType;
            AboutModel.ViewType = viewType;
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
                if (SelectedItem == null || SelectedItem == AppModel)
                {
                    return true;
                }
                return SelectedItem != null ? SelectedItem.IsAppBarVisible : false;
            }
        }

        public bool IsLockScreenVisible
        {
            get { return SelectedItem == null || SelectedItem == AppModel; }
        }

        public bool IsAboutVisible
        {
            get { return SelectedItem == null || SelectedItem == AppModel; }
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
                AppModel.LoadItems(isNetworkAvailable),
                GoProVODModel.LoadItems(isNetworkAvailable),
                GPTipsTricksModel.LoadItems(isNetworkAvailable),
                GoProPhotosModel.LoadItems(isNetworkAvailable),
                GoProMountsModel.LoadItems(isNetworkAvailable),
                AboutModel.LoadItems(isNetworkAvailable),
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
                    LockScreenServices.SetLockScreen("/Assets/LockScreenImage.png");
                });
            }
        }
    }
}
