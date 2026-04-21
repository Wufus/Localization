using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Localizer
{
    public static class Localizer
    {

        public static Microsoft.Windows.ApplicationModel.Resources.ResourceLoader RL;

        public static String GetString(String key)
        {
            if (RL == null)
                Load();
            try
            {
                return RL?.GetString(key);
            }
            catch
            {
                return null;
            }
        }

        static void Load()
        {
            try
            {
                RL = new Microsoft.Windows.ApplicationModel.Resources.ResourceLoader("Localizer.pri");
            }
            catch { }
        }
    }
}
