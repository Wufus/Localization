using Microsoft.UI.Xaml.Controls;
using System;


namespace Localization
{
    public sealed partial class BlankPage : Page
    {
        public BlankPage()
        {
            InitializeComponent();

            // 
            var runtimeLanguages = Windows.Globalization.ApplicationLanguages.Languages;

            try
            {
                String value = new Microsoft.Windows.ApplicationModel.Resources.ResourceLoader("Localization.pri").GetString("TestField");
                UI_ThisProjectDefaultResources.Text = value;
            }
            catch { }
            try
            {
                String value = new Microsoft.Windows.ApplicationModel.Resources.ResourceLoader("Localization.pri", "Errors").GetString("TestField");
                UI_ThisProjectAnotherFileResources.Text = value;
            }
            catch { }
            try
            {
                String value = new Microsoft.Windows.ApplicationModel.Resources.ResourceLoader("Localizer.pri", "Localizer").GetString("Resources/TestField");
                UI_AnotherProjectDefaultResources.Text = value;
            }
            catch { }
            try
            {
                String value = new Microsoft.Windows.ApplicationModel.Resources.ResourceLoader("Localizer.pri", "Localizer").GetString("Errors/TestField");
                UI_AnotherProjectAnotherFileResources.Text = value;
            }
            catch { }

            UI_AnotherProjectDefaultResources2.Text = Localizer.Instance.GetString("Resources/TestField");
            UI_AnotherProjectAnotherFileResources2.Text = Localizer.Instance.GetString("Errors/TestField");
        }
    }
}
