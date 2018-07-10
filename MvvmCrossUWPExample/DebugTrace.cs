
namespace MvvmCrossUWPExample
{
    using MvvmCross.Platform.Platform;
    using System;
    using System.Diagnostics;

    /// <summary>
    /// the debug trace logger class
    /// </summary>
    /// <seealso cref="MvvmCross.Platform.Platform.IMvxTrace" />
    public class DebugTrace : IMvxTrace
    {
        /// <summary>
        /// Traces the specified level.
        /// </summary>
        /// <param name="level">The level.</param>
        /// <param name="tag">The tag.</param>
        /// <param name="message">The message.</param>
        public void Trace(MvxTraceLevel level, string tag, Func<string> message)
        {
            Debug.WriteLine($"{tag}:{level}:{message()}");
        }

        /// <summary>
        /// Traces the specified level.
        /// </summary>
        /// <param name="level">The level.</param>
        /// <param name="tag">The tag.</param>
        /// <param name="message">The message.</param>
        public void Trace(MvxTraceLevel level, string tag, string message)
        {
            Debug.WriteLine($"{tag}:{level}:{message}");
        }

        /// <summary>
        /// Traces the specified level.
        /// </summary>
        /// <param name="level">The level.</param>
        /// <param name="tag">The tag.</param>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        public void Trace(MvxTraceLevel level, string tag, string message, params object[] args)
        {
            try
            {
                Debug.WriteLine($"{tag}:{level}:{message}", args);
            }
            catch (FormatException ex)
            {
                this.Trace(MvxTraceLevel.Error, tag, $"Exeption during trace of {level} {message}");
            }
        }
    }
}
