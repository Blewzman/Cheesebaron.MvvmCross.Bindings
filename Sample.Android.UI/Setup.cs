using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using Sample.Core;

namespace Sample.Droid.UI
{
    public class Setup
        : MvxAndroidSetup
    {
        public Setup(Context applicationContext)
            : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }

        protected override IEnumerable<Assembly> AndroidViewAssemblies
        {
            get 
            {
                return base.AndroidViewAssemblies.Concat(new[] { typeof(Cheesebaron.MvvmCross.Bindings.Droid.BindableViewPager).Assembly });
            }
        }
    }
}