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
    public partial class NeumorphicTextButton : UserControl
    {
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(NeumorphicTextButton), new PropertyMetadata(""));

        public static readonly RoutedEvent ButtonClickEvent = 
            EventManager.RegisterRoutedEvent(nameof(ButtonClick), RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(NeumorphicTextButton));

        public event RoutedEventHandler ButtonClick
        {
            add { AddHandler(ButtonClickEvent, value); } 
            remove { RemoveHandler(ButtonClickEvent, value);}
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(ButtonClickEvent));
        }

        public NeumorphicTextButton()
        {

            
            InitializeComponent();
            /*OuterUpperBorderWidthAnim.From = OuterUpperBorder.ActualWidth - 10;
            OuterUpperBorderWidthAnim.To = OuterUpperBorder.ActualWidth - 20;

            OuterUpperBorderHeightAnim.From = OuterUpperBorder.ActualHeight - 10;
            OuterUpperBorderHeightAnim.To = OuterUpperBorder.ActualHeight - 20;

            OuterUpperBorderWidthAnim2.From = OuterLowerBorder.ActualWidth - 10;
            OuterUpperBorderWidthAnim2.To = OuterLowerBorder.ActualWidth - 20;

            OuterUpperBorderHeightAnim2.From = OuterLowerBorder.ActualHeight - 10;
            OuterUpperBorderHeightAnim2.To = OuterLowerBorder.ActualHeight - 20;

            OuterUpperBorderWidthAnim3.From = OuterUpperBorder.ActualWidth - 10;
            OuterUpperBorderWidthAnim3.To = OuterUpperBorder.ActualWidth;

            OuterUpperBorderHeightAnim3.From = OuterUpperBorder.ActualHeight - 10;
            OuterUpperBorderHeightAnim3.To = OuterUpperBorder.ActualHeight;

            OuterUpperBorderWidthAnim4.From = OuterLowerBorder.ActualWidth - 10;
            OuterUpperBorderWidthAnim4.To = OuterLowerBorder.ActualWidth;

            OuterUpperBorderHeightAnim4.From = OuterLowerBorder.ActualHeight - 10;
            OuterUpperBorderHeightAnim4.To = OuterLowerBorder.ActualHeight;*/
        }
    }
}
