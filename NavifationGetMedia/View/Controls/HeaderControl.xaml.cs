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
using NavifationGetMedia.Helpers;

namespace NavifationGetMedia.View.Controls
{
    /// <summary>
    /// Логика взаимодействия для HeaderControl.xaml
    /// </summary>
    public partial class HeaderControl : UserControl
    {
        public static readonly DependencyProperty TextBoxIsFocusedProperty = DependencyProperty.Register(
            nameof(TextBoxIsFocused), typeof(bool), typeof(HeaderControl), new PropertyMetadata(default(bool)));

        public bool TextBoxIsFocused
        {
            get { return (bool)GetValue(TextBoxIsFocusedProperty); }
            set { SetValue(TextBoxIsFocusedProperty, value); }
        }

        public HeaderControl()
        {
            InitializeComponent();
            this.DataContext = Application.Current.MainWindow.DataContext;
        }
    }
}
