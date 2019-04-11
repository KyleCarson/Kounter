namespace Kounter.Views
{
    using Kounter.ViewModels;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainView()
        {
            this.DataContext = new MainViewModel();

            this.InitializeComponent();
        }
    }
}
