namespace ViewModels
{
    using System;
    using MvvmCross.Core.Navigation;
    using MvvmCross.Core.ViewModels;
    using MvvmCross.Platform;
    using MvvmCrossUWPExample.Core.ViewModels;

    /// <summary>
    /// the first views view model for logic
    /// </summary>
    /// <seealso cref="MvvmCross.Core.ViewModels.MvxViewModel" />
    public class FirstViewModel : MvxViewModel
    {
        /// <summary>
        /// The hello
        /// </summary>
        private string hello;

        /// <summary>
        /// The move next view
        /// </summary>
        private MvxCommand moveNextView;

        /// <summary>
        /// Gets or sets the hello.
        /// </summary>
        /// <value>
        /// The hello.
        /// </value>
        public string Hello
        {
            get { return this.hello; }
            set { this.SetProperty(ref this.hello, value); }
        }

        /// <summary>
        /// Gets or sets the move next view.
        /// </summary>
        /// <value>
        /// The move next view.
        /// </value>
        public MvxCommand MoveNextView
        {
            get { return this.moveNextView ?? (this.moveNextView = new MvxCommand(this.MoveNextViewAction)); }
        }

        /// <summary>
        /// Moves the next view action.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void MoveNextViewAction()
        {
            var navService = Mvx.Resolve<IMvxNavigationService>();
            navService.Navigate<SecondViewModel>();
        }
    }
}