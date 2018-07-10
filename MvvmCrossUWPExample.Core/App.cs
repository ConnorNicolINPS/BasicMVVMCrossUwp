namespace MvvmCrossUWPExample.Core
{
    using MvvmCross.Core.ViewModels;
    using MvvmCross.Platform.IoC;

    /// <summary>
    /// Main App class
    /// </summary>
    /// <seealso cref="MvvmCross.Core.ViewModels.MvxApplication" />
    public class App : MvxApplication
    {
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public override void Initialize()
        {
            CreatableTypes().EndingWith("Service").AsInterfaces().RegisterAsLazySingleton();
            RegisterAppStart<ViewModels.FirstViewModel>();
        }
    }
}
