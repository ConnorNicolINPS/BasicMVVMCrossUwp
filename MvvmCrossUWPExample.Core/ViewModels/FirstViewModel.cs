namespace ViewModels
{
    using MvvmCross.Core.ViewModels;

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

    }
}