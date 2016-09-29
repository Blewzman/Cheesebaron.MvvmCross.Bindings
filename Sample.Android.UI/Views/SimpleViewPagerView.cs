using Android.App;
using Cheesebaron.MvvmCross.Bindings.Droid;
using MvvmCross.Droid.Views;
using Sample.Core.ViewModels;

namespace Sample.Droid.UI.Views
{
    [Activity(Label = "ViewPager!!!", LaunchMode = Android.Content.PM.LaunchMode.SingleTop)]
    public class ViewPagerShizzleView
        : MvxActivity
    {
        public new SimpleListViewModel ViewModel
        {
            get { return (SimpleListViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Page_SimpleViewPagerView);

            var pager = FindViewById<BindableViewPager>(Resource.Id.viewPagerView);
        }
    }
}
