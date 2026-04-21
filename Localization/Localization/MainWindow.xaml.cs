using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;


namespace Localization
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void LangButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if(sender is FrameworkElement fe)
            {
                if(fe.Tag is String tagStr)
                    Microsoft.Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = tagStr;
                UI_LangSelector.Visibility = Visibility.Collapsed;
                UI_Frame.Navigate(typeof(BlankPage));
            }
        }
    }
}
