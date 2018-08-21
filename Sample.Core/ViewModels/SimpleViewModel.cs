using Cheesebaron.MvvmCross.Bindings;
using MvvmCross.ViewModels;

namespace Sample.Core.ViewModels
{
    public class SimpleViewModel
        : MvxNotifyPropertyChanged, IHasPageTitle
    {
        private string _name;
        private string _description;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged(() => Name);
            }
        }
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                RaisePropertyChanged(() => Description);
            }
        }

        public string Title
        {
            get
            {
                return "Title of page " + this.Name;
            }
        }
    }
}
