using System.Windows;

namespace Corners
{
    /// <summary>
    /// Логика взаимодействия для CDialog.xaml
    /// </summary>
    public partial class CStepDialog : Window
    {
        public CStepDialog()
        {
            InitializeComponent();
        }

        public void StepButton_Click(object sender, RoutedEventArgs e)
        {
            //StartStopcs.BStart = true;
            this.Close();
        }              

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ContinueCheck.IsChecked = StartStopcs.BContinue;
        }

        private void ContinueCheck_Unchecked(object sender, RoutedEventArgs e)
        {
            StartStopcs.BContinue = false;
            
        }

        private void ContinueCheck_Checked(object sender, RoutedEventArgs e)
        {
            StartStopcs.BContinue = true;
            
        }

        private void HButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
