namespace MvvmCrossUWPExample
{
    using MvvmCross.Core.ViewModels;
    using MvvmCross.Platform.Platform;
    using MvvmCross.Uwp.Platform;
    using Windows.UI.Xaml.Controls;

    /// <summary>
    /// the class used to setup the application 
    /// </summary>
    public class Setup : MvxWindowsSetup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Setup"/> class.
        /// </summary>
        /// <param name="rootFrame">The root frame.</param>
        public Setup(Frame rootFrame) : base(rootFrame)
        {
        }

        /// <summary>
        /// Creates the application.
        /// </summary>
        /// <returns></returns>
        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}
