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

namespace ValorantCardandTitleChanger.Controls
{
    /// <summary>
    /// Interaction logic for NeumorphicImage.xaml
    /// </summary>
    public partial class NeumorphicImage : UserControl
    {

        public string ImageSrc
        {
            get { return (string)GetValue(ImageSrcProperty); }
            set { SetValue(ImageSrcProperty, value); }
        }

        public static readonly DependencyProperty ImageSrcProperty =
            DependencyProperty.Register("ImageSrc", typeof(string), typeof(NeumorphicImage), new PropertyMetadata(""));

        public static readonly RoutedEvent ButtonClickEvent =
            EventManager.RegisterRoutedEvent(nameof(ButtonClick), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(NeumorphicImage));

        public event RoutedEventHandler ButtonClick
        {
            add { AddHandler(ButtonClickEvent, value); }
            remove { RemoveHandler(ButtonClickEvent, value); }
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(ButtonClickEvent));
        }
        public NeumorphicImage()
        {
            InitializeComponent();
        }
    }
}
