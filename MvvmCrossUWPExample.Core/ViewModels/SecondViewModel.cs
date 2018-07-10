using MvvmCross.Core.ViewModels;

namespace MvvmCrossUWPExample.Core.ViewModels
{
    /// <summary>
    /// the second views logic
    /// </summary>
    /// <seealso cref="MvvmCross.Core.ViewModels.MvxViewModel" />
    public class SecondViewModel : MvxViewModel
    {
        /// <summary>
        /// The basic text
        /// </summary>
        private string basicText;

        /// <summary>
        /// Initializes a new instance of the <see cref="SecondViewModel"/> class.
        /// </summary>
        public SecondViewModel()
        {
            this.BasicText = "this is more text from the VM of the secondview - this is bound text";
        }

        /// <summary>
        /// Gets or sets the basic text.
        /// </summary>
        /// <value>
        /// The basic text.
        /// </value>
        public string BasicText
        {
            get { return this.basicText; }
            set { this.SetProperty(ref this.basicText, value); }
        }
    }
}