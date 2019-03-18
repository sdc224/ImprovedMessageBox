// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Interaction logic for MainWindow.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SampleWpfApp
{
    using System.Windows;
    using System.Windows.Media;

    using MessageBox;

    using MessageBoxImage = MessageBox.MessageBoxImage;

    /// <summary>
    /// Interaction logic for MainWindow.XAML
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SampleWpfApp.MainWindow" /> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();

            /*var r = ImprovedMessageBox.Show(
                "Message Box Title",
                "Are you sure?",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning,
                Color.FromRgb(38, 80, 138),
                Color.FromRgb(42, 115, 158),
                Color.FromRgb(112, 164, 185),
                Color.FromRgb(205, 223, 233));*/

            var r = ImprovedMessageBox.Show("Title", "Are you sure?", MessageBoxButton.YesNo, Brushes.White, Brushes.Black);

            if (r != MessageBoxResult.Yes)
            {
                this.Close();
                return;
            }
        }
    }
}
