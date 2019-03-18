// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ImprovedMessageBox.xaml.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Interaction logic for ImprovedMessageBox.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MessageBox
{
    using System;
    using System.IO;
    using System.Security;
    using System.Windows;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    /// <summary>
    /// Interaction logic for MainWindow.XAML
    /// </summary>
    public partial class ImprovedMessageBox : Window
    {
        /// <summary>
        /// The message box.
        /// </summary>
        private static ImprovedMessageBox messageBox;

        /// <summary>
        /// The result.
        /// </summary>
        private static MessageBoxResult result = MessageBoxResult.No;

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:ImprovedMessageBox.MainWindow" /> class.
        /// </summary>
        public ImprovedMessageBox()
        {
            this.InitializeComponent();
        }
        
        /// <summary>
        /// The show.
        /// </summary>
        /// <param name="caption">
        /// The caption.
        /// </param>
        /// <param name="msg">
        /// The message.
        /// </param>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <param name="backgroundBrush">
        /// The background Brush.
        /// </param>
        /// <param name="borderBrush">
        /// The border Brush.
        /// </param>
        /// <param name="titleBarColor1">
        /// The title Bar Color 1.
        /// For e.g. - Color.FromArgb(255, 38, 80, 138)
        /// </param>
        /// <param name="titleBarColor2">
        /// The title Bar Color 2.
        /// For e.g. - Color.FromArgb(255, 42, 115, 158)
        /// </param>
        /// <param name="mainAreaColor1">
        /// The main Area Color 1.
        /// For e.g. - Color.FromArgb(255, 112, 164, 185)
        /// </param>
        /// <param name="mainAreaColor2">
        /// The main Area Color 2.
        /// For e.g. - Color.FromArgb(255, 205, 223, 233)
        /// </param>
        /// <returns>
        /// The <see cref="MessageBoxResult"/>.
        /// </returns>
        [SecurityCritical]
        public static MessageBoxResult Show(
            string caption,
            string msg,
            MessageBoxType type,
            Brush backgroundBrush = null,
            Brush borderBrush = null,
            Color? titleBarColor1 = null,
            Color? titleBarColor2 = null,
            Color? mainAreaColor1 = null,
            Color? mainAreaColor2 = null)
        {
            switch (type)
            {
                case MessageBoxType.ConfirmationWithYesNo:
                    return Show(
                        caption,
                        msg,
                        MessageBoxButton.YesNo,
                        MessageBoxImage.Question,
                        backgroundBrush,
                        borderBrush,
                        titleBarColor1,
                        titleBarColor2,
                        mainAreaColor1,
                        mainAreaColor2);
                case MessageBoxType.ConfirmationWithYesNoCancel:
                    return Show(
                        caption,
                        msg,
                        MessageBoxButton.YesNoCancel,
                        MessageBoxImage.Question,
                        backgroundBrush,
                        borderBrush,
                        titleBarColor1,
                        titleBarColor2,
                        mainAreaColor1,
                        mainAreaColor2);
                case MessageBoxType.Information:
                    return Show(
                        caption,
                        msg,
                        MessageBoxButton.OK,
                        MessageBoxImage.Information,
                        backgroundBrush,
                        borderBrush,
                        titleBarColor1,
                        titleBarColor2,
                        mainAreaColor1,
                        mainAreaColor2);
                case MessageBoxType.Error:
                    return Show(
                        caption,
                        msg,
                        MessageBoxButton.OK,
                        MessageBoxImage.Error,
                        backgroundBrush,
                        borderBrush,
                        titleBarColor1,
                        titleBarColor2,
                        mainAreaColor1,
                        mainAreaColor2);
                case MessageBoxType.Warning:
                    return Show(
                        caption,
                        msg,
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning,
                        backgroundBrush,
                        borderBrush,
                        titleBarColor1,
                        titleBarColor2,
                        mainAreaColor1,
                        mainAreaColor2);
                default:
                    return MessageBoxResult.No;
            }
        }

        /// <summary>
        /// The show.
        /// </summary>
        /// <param name="msg">
        /// The message.
        /// </param>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <param name="backgroundBrush">
        /// The background Brush.
        /// </param>
        /// <param name="borderBrush">
        /// The border Brush.
        /// </param>
        /// <param name="titleBarColor1">
        /// The title Bar Color 1.
        /// For e.g. - Color.FromArgb(255, 38, 80, 138)
        /// </param>
        /// <param name="titleBarColor2">
        /// The title Bar Color 2.
        /// For e.g. - Color.FromArgb(255, 42, 115, 158)
        /// </param>
        /// <param name="mainAreaColor1">
        /// The main Area Color 1.
        /// For e.g. - Color.FromArgb(255, 112, 164, 185)
        /// </param>
        /// <param name="mainAreaColor2">
        /// The main Area Color 2.
        /// For e.g. - Color.FromArgb(255, 205, 223, 233)
        /// </param>
        /// <returns>
        /// The <see cref="MessageBoxResult"/>.
        /// </returns>
        [SecurityCritical]
        public static MessageBoxResult Show(
            string msg,
            MessageBoxType type,
            Brush backgroundBrush = null,
            Brush borderBrush = null,
            Color? titleBarColor1 = null,
            Color? titleBarColor2 = null,
            Color? mainAreaColor1 = null,
            Color? mainAreaColor2 = null)
        {
            return Show(
                string.Empty,
                msg,
                type,
                backgroundBrush,
                borderBrush,
                titleBarColor1,
                titleBarColor2,
                mainAreaColor1,
                mainAreaColor2);
        }

        /// <summary>
        /// The show.
        /// </summary>
        /// <param name="msg">
        /// The message.
        /// </param>
        /// <param name="backgroundBrush">
        /// The background Brush.
        /// </param>
        /// <param name="borderBrush">
        /// The border Brush.
        /// </param>
        /// <param name="titleBarColor1">
        /// The title Bar Color 1.
        /// For e.g. - Color.FromArgb(255, 38, 80, 138)
        /// </param>
        /// <param name="titleBarColor2">
        /// The title Bar Color 2.
        /// For e.g. - Color.FromArgb(255, 42, 115, 158)
        /// </param>
        /// <param name="mainAreaColor1">
        /// The main Area Color 1.
        /// For e.g. - Color.FromArgb(255, 112, 164, 185)
        /// </param>
        /// <param name="mainAreaColor2">
        /// The main Area Color 2.
        /// For e.g. - Color.FromArgb(255, 205, 223, 233)
        /// </param>
        /// <returns>
        /// The <see cref="MessageBoxResult"/>.
        /// </returns>
        [SecurityCritical]
        public static MessageBoxResult Show(
            string msg,
            Brush backgroundBrush = null,
            Brush borderBrush = null,
            Color? titleBarColor1 = null,
            Color? titleBarColor2 = null,
            Color? mainAreaColor1 = null,
            Color? mainAreaColor2 = null)
        {
            return Show(string.Empty, msg, MessageBoxButton.OK, MessageBoxImage.None, backgroundBrush, borderBrush, titleBarColor1, titleBarColor2, mainAreaColor1, mainAreaColor2);
        }

        /// <summary>
        /// The show.
        /// </summary>
        /// <param name="caption">
        /// The caption.
        /// </param>
        /// <param name="text">
        /// The text.
        /// </param>
        /// <param name="backgroundBrush">
        /// The background Brush.
        /// </param>
        /// <param name="borderBrush">
        /// The border Brush.
        /// </param>
        /// <param name="titleBarColor1">
        /// The title Bar Color 1.
        /// For e.g. - Color.FromArgb(255, 38, 80, 138)
        /// </param>
        /// <param name="titleBarColor2">
        /// The title Bar Color 2.
        /// For e.g. - Color.FromArgb(255, 42, 115, 158)
        /// </param>
        /// <param name="mainAreaColor1">
        /// The main Area Color 1.
        /// For e.g. - Color.FromArgb(255, 112, 164, 185)
        /// </param>
        /// <param name="mainAreaColor2">
        /// The main Area Color 2.
        /// For e.g. - Color.FromArgb(255, 205, 223, 233)
        /// </param>
        /// <returns>
        /// The <see cref="MessageBoxResult"/>.
        /// </returns>
        [SecurityCritical]
        public static MessageBoxResult Show(
            string caption,
            string text,
            Brush backgroundBrush = null,
            Brush borderBrush = null,
            Color? titleBarColor1 = null,
            Color? titleBarColor2 = null,
            Color? mainAreaColor1 = null,
            Color? mainAreaColor2 = null)
        {
            return Show(
                caption,
                text,
                MessageBoxButton.OK,
                MessageBoxImage.None,
                backgroundBrush,
                borderBrush,
                titleBarColor1,
                titleBarColor2,
                mainAreaColor1,
                mainAreaColor2);
        }

        /// <summary>
        /// The show.
        /// </summary>
        /// <param name="caption">
        /// The caption.
        /// </param>
        /// <param name="text">
        /// The text.
        /// </param>
        /// <param name="button">
        /// The button.
        /// </param>
        /// <param name="backgroundBrush">
        /// The background Brush.
        /// </param>
        /// <param name="borderBrush">
        /// The border Brush.
        /// </param>
        /// <param name="titleBarColor1">
        /// The title Bar Color 1.
        /// For e.g. - Color.FromArgb(255, 38, 80, 138)
        /// </param>
        /// <param name="titleBarColor2">
        /// The title Bar Color 2.
        /// For e.g. - Color.FromArgb(255, 42, 115, 158)
        /// </param>
        /// <param name="mainAreaColor1">
        /// The main Area Color 1.
        /// For e.g. - Color.FromArgb(255, 112, 164, 185)
        /// </param>
        /// <param name="mainAreaColor2">
        /// The main Area Color 2.
        /// For e.g. - Color.FromArgb(255, 205, 223, 233)
        /// </param>
        /// <returns>
        /// The <see cref="MessageBoxResult"/>.
        /// </returns>
        [SecurityCritical]
        public static MessageBoxResult Show(
            string caption,
            string text,
            MessageBoxButton button,
            Brush backgroundBrush = null,
            Brush borderBrush = null,
            Color? titleBarColor1 = null,
            Color? titleBarColor2 = null,
            Color? mainAreaColor1 = null,
            Color? mainAreaColor2 = null)
        {
            return Show(
                caption,
                text,
                button,
                MessageBoxImage.None,
                backgroundBrush,
                borderBrush,
                titleBarColor1,
                titleBarColor2,
                mainAreaColor1,
                mainAreaColor2);
        }

        /// <summary>
        /// The show.
        /// </summary>
        /// <param name="caption">
        /// The caption.
        /// </param>
        /// <param name="text">
        /// The text.
        /// </param>
        /// <param name="button">
        /// The button.
        /// </param>
        /// <param name="image">
        /// The image.
        /// </param>
        /// <param name="backgroundBrush">
        /// The background Brush.
        /// </param>
        /// <param name="borderBrush">
        /// The border Brush.
        /// </param>
        /// <param name="titleBarColor1">
        /// The title Bar Color 1.
        /// For e.g. - Color.FromArgb(255, 38, 80, 138)
        /// </param>
        /// <param name="titleBarColor2">
        /// The title Bar Color 2.
        /// For e.g. - Color.FromArgb(255, 42, 115, 158)
        /// </param>
        /// <param name="mainAreaColor1">
        /// The main Area Color 1.
        /// For e.g. - Color.FromArgb(255, 112, 164, 185)
        /// </param>
        /// <param name="mainAreaColor2">
        /// The main Area Color 2.
        /// For e.g. - Color.FromArgb(255, 205, 223, 233)
        /// </param>
        /// <returns>
        /// The <see cref="MessageBoxResult"/>.
        /// </returns>
        [SecurityCritical]
        public static MessageBoxResult Show(
            string caption,
            string text,
            MessageBoxButton button,
            MessageBoxImage image,
            Brush backgroundBrush = null,
            Brush borderBrush = null,
            Color? titleBarColor1 = null,
            Color? titleBarColor2 = null,
            Color? mainAreaColor1 = null,
            Color? mainAreaColor2 = null)
        {
            messageBox = new ImprovedMessageBox { TextBlockMessage = { Text = text }, MessageTitle = { Text = caption } };

            /*var color1 = (Color)ColorConverter.ConvertFromString("#26508A"); // Color.FromArgb(255, 38, 80, 138)
            var color2 = (Color)ColorConverter.ConvertFromString("#2A739E"); // Color.FromArgb(255, 42, 115, 158)
            var color3 = (Color)ColorConverter.ConvertFromString("#70A4B9"); // Color.FromArgb(255, 112, 164, 185)
            var color4 = (Color)ColorConverter.ConvertFromString("#CDDFE9"); // Color.FromArgb(255, 205, 223, 233)
            */

            if (backgroundBrush != null)
            {
                messageBox.WindowMessageBox.Background = backgroundBrush;
            }

            if (borderBrush != null)
            {
                messageBox.Border.BorderBrush = borderBrush;
            }

            try
            {
                if (titleBarColor1 != null && titleBarColor2 != null)
                {
                    messageBox.GradientStopColorForTitleBar.Color = (Color)titleBarColor1;
                    messageBox.GradientStopColorForTitleBar2.Color = (Color)titleBarColor2;
                }
                else if (titleBarColor1 != null || titleBarColor2 != null)
                {
                    throw new NotSupportedException("Please specify both the colors!");
                }

                if (mainAreaColor1 != null && mainAreaColor2 != null)
                {
                    messageBox.GradientStopColorForMainArea.Color = (Color)mainAreaColor1;
                    messageBox.GradientStopColorForMainArea2.Color = (Color)mainAreaColor2;
                }
                else if (mainAreaColor1 != null || mainAreaColor2 != null)
                {
                    throw new NotSupportedException("Please specify both the colors!");
                }
            }
            catch (Exception e)
            {
                messageBox.TextBlockMessage.Text = e.Message;
            }

            SetVisibilityOfButtons(button);
            SetImageOfMessageBox(image);
            messageBox.ShowDialog();
            return result;
        }

        /// <summary>
        /// The show.
        /// </summary>
        /// <param name="caption">
        /// The caption.
        /// </param>
        /// <param name="text">
        /// The text.
        /// </param>
        /// <param name="button">
        /// The button.
        /// </param>
        /// <param name="image">
        /// The image in string path.
        /// </param>
        /// <param name="backgroundBrush">
        /// The background Brush.
        /// </param>
        /// <param name="borderBrush">
        /// The border Brush.
        /// </param>
        /// <param name="titleBarColor1">
        /// The title Bar Color 1.
        /// For e.g. - Color.FromArgb(255, 38, 80, 138)
        /// </param>
        /// <param name="titleBarColor2">
        /// The title Bar Color 2.
        /// For e.g. - Color.FromArgb(255, 42, 115, 158)
        /// </param>
        /// <param name="mainAreaColor1">
        /// The main Area Color 1.
        /// For e.g. - Color.FromArgb(255, 112, 164, 185)
        /// </param>
        /// <param name="mainAreaColor2">
        /// The main Area Color 2.
        /// For e.g. - Color.FromArgb(255, 205, 223, 233)
        /// </param>
        /// <returns>
        /// The <see cref="MessageBoxResult"/>.
        /// </returns>
        [SecurityCritical]
        public static MessageBoxResult Show(
            string caption,
            string text,
            MessageBoxButton button,
            string image,
            Brush backgroundBrush = null,
            Brush borderBrush = null,
            Color? titleBarColor1 = null,
            Color? titleBarColor2 = null,
            Color? mainAreaColor1 = null,
            Color? mainAreaColor2 = null)
        {
            messageBox = new ImprovedMessageBox { TextBlockMessage = { Text = text }, MessageTitle = { Text = caption } };

            /*var color1 = (Color)ColorConverter.ConvertFromString("#26508A"); // Color.FromArgb(255, 38, 80, 138)
            var color2 = (Color)ColorConverter.ConvertFromString("#2A739E"); // Color.FromArgb(255, 42, 115, 158)
            var color3 = (Color)ColorConverter.ConvertFromString("#70A4B9"); // Color.FromArgb(255, 112, 164, 185)
            var color4 = (Color)ColorConverter.ConvertFromString("#CDDFE9"); // Color.FromArgb(255, 205, 223, 233)
            */

            if (backgroundBrush != null)
            {
                messageBox.WindowMessageBox.Background = backgroundBrush;
            }

            if (borderBrush != null)
            {
                messageBox.Border.BorderBrush = borderBrush;
            }

            try
            {
                if (titleBarColor1 != null && titleBarColor2 != null)
                {
                    messageBox.GradientStopColorForTitleBar.Color = (Color)titleBarColor1;
                    messageBox.GradientStopColorForTitleBar2.Color = (Color)titleBarColor2;
                }
                else if (titleBarColor1 != null || titleBarColor2 != null)
                {
                    throw new NotSupportedException("Please specify both the colors!");
                }

                if (mainAreaColor1 != null && mainAreaColor2 != null)
                {
                    messageBox.GradientStopColorForMainArea.Color = (Color)mainAreaColor1;
                    messageBox.GradientStopColorForMainArea2.Color = (Color)mainAreaColor2;
                }
                else if (mainAreaColor1 != null || mainAreaColor2 != null)
                {
                    throw new NotSupportedException("Please specify both the colors!");
                }
            }
            catch (Exception e)
            {
                messageBox.TextBlockMessage.Text = e.Message;
            }

            SetVisibilityOfButtons(button);

            try
            {
                if (!string.IsNullOrEmpty(image))
                {
                    messageBox.SetImage(image);
                    messageBox.Image.Visibility = Visibility.Visible;
                }
            }
            catch (Exception e)
            {
                messageBox.TextBlockMessage.Text = e.Message;
            }

            messageBox.ShowDialog();
            return result;
        }

        /// <summary>
        /// The set visibility of buttons.
        /// </summary>
        /// <param name="button">
        /// The button.
        /// </param>
        private static void SetVisibilityOfButtons(MessageBoxButton button)
        {
            switch (button)
            {
                case MessageBoxButton.OK:
                    messageBox.ButtonCancel.Visibility = Visibility.Collapsed;
                    messageBox.ButtonNo.Visibility = Visibility.Collapsed;
                    messageBox.ButtonYes.Visibility = Visibility.Collapsed;
                    messageBox.ButtonOk.Focus();
                    break;
                case MessageBoxButton.OKCancel:
                    messageBox.ButtonNo.Visibility = Visibility.Collapsed;
                    messageBox.ButtonYes.Visibility = Visibility.Collapsed;
                    messageBox.ButtonCancel.Focus();
                    break;
                case MessageBoxButton.YesNo:
                    messageBox.ButtonOk.Visibility = Visibility.Collapsed;
                    messageBox.ButtonCancel.Visibility = Visibility.Collapsed;
                    messageBox.ButtonNo.Focus();
                    break;
                case MessageBoxButton.YesNoCancel:
                    messageBox.ButtonOk.Visibility = Visibility.Collapsed;
                    messageBox.ButtonCancel.Focus();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// The set image of message box.
        /// </summary>
        /// <param name="image">
        /// The image.
        /// </param>
        private static void SetImageOfMessageBox(MessageBoxImage image)
        {
            switch (image)
            {
                case MessageBoxImage.Warning:
                    messageBox.SetImage("Warning.png");
                    break;
                case MessageBoxImage.Question:
                    messageBox.SetImage("Question.png");
                    break;
                case MessageBoxImage.Information:
                    messageBox.SetImage("Information.png");
                    break;
                case MessageBoxImage.Error:
                    messageBox.SetImage("Cancel1.bmp");
                    break;
                case MessageBoxImage.None:
                    break;
                default:
                    messageBox.Image.Visibility = Visibility.Collapsed;
                    break;
            }
        }

        /// <summary>
        /// The button click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender == this.ButtonOk)
            {
                result = MessageBoxResult.OK;
            }
            else if (sender == this.ButtonYes)
            {
                result = MessageBoxResult.Yes;
            }
            else if (sender == this.ButtonNo)
            {
                result = MessageBoxResult.No;
            }
            else if (sender == this.ButtonCancel)
            {
                result = MessageBoxResult.Cancel;
            }
            else
            {
                result = MessageBoxResult.None;
            }

            messageBox.Close();
            messageBox = null;
        }

        /// <summary>
        /// The set image.
        /// </summary>
        /// <param name="imageName">
        /// The image name.
        /// </param>
        private void SetImage(string imageName)
        {
            var uri = imageName;
            var uriSource = new Uri(uri, UriKind.RelativeOrAbsolute);
            try
            {
                this.Image.Source = new BitmapImage(uriSource);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
