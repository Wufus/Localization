using System;


namespace Localizer
{
    /// <summary>
    /// Use it to programmatically retrive string from PRI resources
    /// </summary>
    public static class Instance
    {

        static Microsoft.Windows.ApplicationModel.Resources.ResourceLoader RL;

        /// <summary>
        /// Return string from resources or null if not found
        /// </summary>
        /// <param name="key">Use / for nesting level</param>
        /// <returns>value if found, otherwise null</returns>
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
                System.Diagnostics.Debug.WriteLine($"Cannot found string in PRI file by key={key}");
                return null;
            }
        }

        /// <summary>
        /// One time loading. All submaps will be acessed via tihs one instance
        /// </summary>
        static void Load()
        {
            try
            {
                RL = new Microsoft.Windows.ApplicationModel.Resources.ResourceLoader(nameof(Localizer) + ".pri", nameof(Localizer));
            }
            catch (Exception exc)
            {
                System.Diagnostics.Debug.WriteLine("Cannot load PRI file:");
                System.Diagnostics.Debug.WriteLine(exc.Message);
            }
        }
    }
}