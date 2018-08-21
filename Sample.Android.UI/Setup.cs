using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.ViewModels;
using Sample.Core;

namespace Sample.Droid.UI
{
    public class Setup
        : MvxAndroidSetup
    {
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