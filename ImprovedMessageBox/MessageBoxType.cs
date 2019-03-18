// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MessageBoxType.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the MessageBoxType type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MessageBox
{
    /// <summary>
    /// The message box type.
    /// </summary>
    public enum MessageBoxType
    {
        /// <summary>
        /// The confirmation with yes no.
        /// </summary>
        ConfirmationWithYesNo = 0,

        /// <summary>
        /// The confirmation with yes no cancel.
        /// </summary>
        ConfirmationWithYesNoCancel,

        /// <summary>
        /// The information.
        /// </summary>
        Information,

        /// <summary>
        /// The error.
        /// </summary>
        Error,

        /// <summary>
        /// The warning.
        /// </summary>
        Warning
    }
}