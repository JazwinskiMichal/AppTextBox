using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfApp11
{
    /// <summary>
    /// Interaction logic for AppTextBox.xaml
    /// </summary>
    public partial class AppTextBox : TextBox
    {
        public static new readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(AppTextBox), new FrameworkPropertyMetadata(new PropertyChangedCallback(OnTextPropertyChanged)));
        public new string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        private static void OnTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Debug.WriteLine("OnTextPropertyChanged");
        }

        public AppTextBox()
        {
            InitializeComponent();
        }
    }
}
