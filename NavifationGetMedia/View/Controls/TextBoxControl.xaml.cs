using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NavifationGetMedia.View.Controls
{
    /// <summary>
    /// Логика взаимодействия для TextBoxControl.xaml
    /// </summary>
    public partial class TextBoxControl : UserControl
    {
        public TextBoxControl()
        {
            InitializeComponent();
        }


        private void TextBox_OnGotFocus(object sender, RoutedEventArgs e)
        {
            KeyboardPanel.Visibility = Visibility.Visible;
            MainGrid.Background = new SolidColorBrush(Color.FromRgb(0, 86, 89));
            MainGrid.Opacity = 0.4;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            KeyboardPanel.Visibility = Visibility.Collapsed;
            MainGrid.Background = null;
            MainGrid.Opacity = 1;
        }
    }
}
