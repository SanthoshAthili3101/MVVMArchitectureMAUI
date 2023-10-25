using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVMArchitecture.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private bool _isLoaderRunning;
        private bool _isStartInvestigationButtonVisible;

        private ImageSource clearFilterImg;


        private string cmmsCount = "0";

        private string correctiveActionsCount = "0";

        private ImageSource image;

        private string incidentsCount = "0";

        private bool isBusy;

        private string languageImage = "IndiaFlag.png";

        private string policiesCount = "0";

        private string profilePicture = "ProfilePictureDefault.png";

        private string selectedLanguage = "Choose a Language";

        private string selectedTimeZone = "Choose a Timezone";

        private string title = string.Empty;
        private bool _canNavigate = true;

        public BaseViewModel()
        {
        }

        public Command NavigateToHomePage { get; set; }

        public bool IsLoaderRunning
        {
            get => _isLoaderRunning;
            set
            {
                _isLoaderRunning = value;
                OnPropertyChanged();
            }
        }
        public bool CanNavigate
        {
            get { return _canNavigate; }
            set
            {
                _canNavigate = value;
                OnPropertyChanged();
            }
        }

        public bool IsBusy
        {
            get => isBusy;
            set => SetProperty(ref isBusy, value);
        }

        public string ProfilePicture
        {
            get => profilePicture;
            set
            {
                if (profilePicture == value)
                    return;

                profilePicture = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(DisplayPicture));
            }
        }

        private string incidentName { get; set; }

        public string IncidentName
        {
            get => incidentName;
            set
            {
                incidentName = value;
                OnPropertyChanged();
            }
        }

        private string incidentStatus { get; set; }

        public string IncidentStatus
        {
            get => incidentStatus;
            set
            {
                incidentStatus = value;
                OnPropertyChanged();
            }
        }

        private string statusTextColor { get; set; }

        public string StatusTextColor
        {
            get => statusTextColor;
            set
            {
                statusTextColor = value;
                OnPropertyChanged();
            }
        }

        private string statusColor { get; set; }

        public string StatusColor
        {
            get => statusColor;
            set
            {
                statusColor = value;
                OnPropertyChanged();
            }
        }

        public bool IsStartInvestigationButtonVisible
        {
            get => _isStartInvestigationButtonVisible;
            set
            {
                _isStartInvestigationButtonVisible = value;
                OnPropertyChanged();
            }
        }

        public string DisplayPicture => ProfilePicture;

        public ImageSource Image
        {
            get => image;
            set
            {
                image = value;
                OnPropertyChanged();
            }
        }

        public ImageSource ClearFilterImg
        {
            get => clearFilterImg;
            set
            {
                clearFilterImg = value;
                OnPropertyChanged();
            }
        }

        public string LanguageImage
        {
            get => languageImage;
            set
            {
                if (languageImage == value)
                    return;

                languageImage = value;
                OnPropertyChanged();
            }
        }

        public string SelectedLanguage
        {
            get => selectedLanguage;
            set
            {
                if (selectedLanguage == value)
                    return;

                selectedLanguage = value;
                OnPropertyChanged();
            }
        }

        public string SelectedTimeZone
        {
            get => selectedTimeZone;
            set
            {
                if (selectedTimeZone == value)
                    return;

                selectedTimeZone = value;
                OnPropertyChanged();
            }
        }

        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        public string CmmsCount
        {
            get => cmmsCount;
            set => SetProperty(ref cmmsCount, value);
        }

        public string CorrectiveActionsCount
        {
            get => correctiveActionsCount;
            set => SetProperty(ref correctiveActionsCount, value);
        }

        public string IncidentsCount
        {
            get => incidentsCount;
            set => SetProperty(ref incidentsCount, value);
        }

        public string PoliciesCount
        {
            get => policiesCount;
            set => SetProperty(ref policiesCount, value);
        }


        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        public static string ButtonElementId { get; set; }

        #region CauseCategory

        public static class GlobalCauseCategory
        {
            public static int? CreatIncidentCauseCategoryId { get; set; }
            public static int? CauseCategoryId { get; set; }
            public static int? RealmCauseId { get; set; }
        }
        public static class BodyCode
        {
            public static int? BodyCodeId { get; set; }
            public static int? CreateIncidentBodyCodeId { get; set; }
            public static int? RealmBodyCodeId { get; set; }
        }
        #endregion


        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion


        #region IsReadonlyForAllOverTheApplication

        private bool _isCommonReadonly;

        public bool IsCommonReadonly
        {
            get => _isCommonReadonly;
            set
            {
                _isCommonReadonly = value;
                OnPropertyChanged();
            }
        }

        

        #endregion
    }
}
