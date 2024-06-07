using System.Windows.Controls;
using System.Windows;

namespace AdvancedClicker
{
    public partial class MainWindow : Window
    {
        private int clickCount = 0;
        private int clickMultiplierLevel = 1;
        private int upgradeCost = 10;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            clickCount += clickMultiplierLevel;

            lblClickCount.Content = clickCount.ToString();
        }

        private void UpgradeMultiplier(object sender, RoutedEventArgs e)
        {
            if (clickCount >= upgradeCost)
            {
                clickCount -= upgradeCost;

                clickMultiplierLevel++;

                lblClickCount.Content = clickCount.ToString();
                lblMultiplierLevel.Content = $"{clickMultiplierLevel}x";

                upgradeCost *= 2;
                ((Button)sender).Content = $"Ulepsz mnożnik (Koszt: {upgradeCost})";
            }
            else
            {
                MessageBox.Show("Nie masz wystarczającej liczby kliknięć, aby uaktualnić mnożnik.");
            }
        }
    }
}