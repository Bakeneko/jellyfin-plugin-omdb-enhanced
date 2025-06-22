using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.OMDbEnhanced.Configuration
{
    /// <summary>
    /// Plugin configuration class for OMDb Enhanced plugin.
    /// </summary>
    public class PluginConfiguration : BasePluginConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginConfiguration"/> class.
        /// </summary>
        public PluginConfiguration()
        {
            CastAndCrew = false;
            UsePlotForNonEnglish = false;
            UseGenresForNonEnglish = false;
        }

        /// <summary>
        /// Collect information bout cast and other crew members.
        /// </summary>
        public bool CastAndCrew { get; set; }

        /// <summary>
        /// Collect plot for non english.
        /// </summary>
        public bool UsePlotForNonEnglish { get; set; }

        /// <summary>
        /// Collect genres for non english.
        /// </summary>
        public bool UseGenresForNonEnglish { get; set; }
    }
}
