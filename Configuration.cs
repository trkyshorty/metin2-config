using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metin2_Config
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
            InitializeLanguage();
            InitializeConfiguration();
        }

        private void InitializeLanguage()
        {
            var Language = new IniFile("config.ini");

            if(!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_CAPTINO", "Button")))
            {
                this.Text = Language.Read("CONFIG_STRING_CAPTINO", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_APPLY", "Button")))
            {
                this.okButton.Text = Language.Read("CONFIG_STRING_APPLY", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_CANCLE", "Button")))
            {
                this.cancelButton.Text = Language.Read("CONFIG_STRING_CANCLE", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_GRAPHIC", "Button")))
            {
                this.displayGroup.Text = Language.Read("CONFIG_STRING_GRAPHIC", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_WINDOWSETTING", "Button")))
            {
                this.windowModeGroup.Text = Language.Read("CONFIG_STRING_WINDOWSETTING", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_IMESETTING", "Button")))
            {
                this.imeModeGroup.Text = Language.Read("CONFIG_STRING_IMESETTING", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_GRAPHICSETTING", "Button")))
            {
                this.graphicSettingsGroup.Text = Language.Read("CONFIG_STRING_GRAPHICSETTING", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_SOUND", "Button")))
            {
                this.soundGroup.Text = Language.Read("CONFIG_STRING_SOUND", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_RESOLUTIN", "Button")))
            {
                this.resolutionLabel.Text = Language.Read("CONFIG_STRING_RESOLUTIN", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_FREQUENCY", "Button")))
            {
                this.frequencyLabel.Text = Language.Read("CONFIG_STRING_FREQUENCY", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_GAMMA", "Button")))
            {
                this.gammaLabel.Text = Language.Read("CONFIG_STRING_GAMMA", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_WINDOWMODE", "Button")))
            {
                this.windowedRadioButton.Text = Language.Read("CONFIG_STRING_WINDOWMODE", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_FULLSCREEN", "Button")))
            {
                this.fullScreenRadioButton.Text = Language.Read("CONFIG_STRING_FULLSCREEN", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_GAMEIME", "Button")))
            {
                this.gameImeRadioButton.Text = Language.Read("CONFIG_STRING_GAMEIME", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_OUTIME", "Button")))
            {
                this.externalImeRadioButton.Text = Language.Read("CONFIG_STRING_OUTIME", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_USESOFTCURSOR", "Button")))
            {
                this.softwareCursorCheckbox.Text = Language.Read("CONFIG_STRING_USESOFTCURSOR", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_MUSIC", "Button")))
            {
                this.musicLabel.Text = Language.Read("CONFIG_STRING_MUSIC", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_SOUNDEFFECT", "Button")))
            {
                this.soundEffectsLabel.Text = Language.Read("CONFIG_STRING_SOUNDEFFECT", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_NIGHT_MODE", "Button")))
            {
                this.nightModeGroup.Text = Language.Read("CONFIG_STRING_NIGHT_MODE", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_NIGHT_MODE_ON", "Button")))
            {
                this.nightModeOnRadioButton.Text = Language.Read("CONFIG_STRING_NIGHT_MODE_ON", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_NIGHT_MODE_OFF", "Button")))
            {
                this.nightModeOffRadioButton.Text = Language.Read("CONFIG_STRING_NIGHT_MODE_OFF", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_FOG_MODE", "Button")))
            {
                this.fogGroup.Text = Language.Read("CONFIG_STRING_FOG_MODE", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_FOG_MODE_ON", "Button")))
            {
                this.fogOnRadioButton.Text = Language.Read("CONFIG_STRING_FOG_MODE_ON", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_FOG_MODE_OFF", "Button")))
            {
                this.fogOffRadioButton.Text = Language.Read("CONFIG_STRING_FOG_MODE_OFF", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_SNOW_MODE", "Button")))
            {
                this.snowfallGroup.Text = Language.Read("CONFIG_STRING_SNOW_MODE", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_SNOW_MODE_ON", "Button")))
            {
                this.snowfallOnRadioButton.Text = Language.Read("CONFIG_STRING_SNOW_MODE_ON", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_SNOW_MODE_OFF", "Button")))
            {
                this.snowfallOffRadioButton.Text = Language.Read("CONFIG_STRING_SNOW_MODE_OFF", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_SNOW_TEXTURE_MODE", "Button")))
            {
                this.snowTexturesGroup.Text = Language.Read("CONFIG_STRING_SNOW_TEXTURE_MODE", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_SNOW_TEXTURE_MODE_ON", "Button")))
            {
                this.snowTexturesOnRadioButton.Text = Language.Read("CONFIG_STRING_SNOW_TEXTURE_MODE_ON", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_SNOW_TEXTURE_MODE_OFF", "Button")))
            {
                this.snowTexturesOffRadioButton.Text = Language.Read("CONFIG_STRING_SNOW_TEXTURE_MODE_OFF", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_PRIVATE_SHOP", "Button")))
            {
                this.privateShopsLabel.Text = Language.Read("CONFIG_STRING_PRIVATE_SHOP", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_DROP_ITEM", "Button")))
            {
                this.itemDropsLabel.Text = Language.Read("CONFIG_STRING_DROP_ITEM", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_PET", "Button")))
            {
                this.petsGroup.Text = Language.Read("CONFIG_STRING_PET", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_PET_ON", "Button")))
            {
                this.petsOnRadioButton.Text = Language.Read("CONFIG_STRING_PET_ON", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_PET_OFF", "Button")))
            {
                this.petsOffRadioButton.Text = Language.Read("CONFIG_STRING_PET_OFF", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_NPC_NAME", "Button")))
            {
                this.npcNamesGroup.Text = Language.Read("CONFIG_STRING_NPC_NAME", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_NPC_NAME_ON", "Button")))
            {
                this.npcNamesOnRadioButton.Text = Language.Read("CONFIG_STRING_NPC_NAME_ON", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_NPC_NAME_OFF", "Button")))
            {
                this.npcNamesOffRadioButton.Text = Language.Read("CONFIG_STRING_NPC_NAME_OFF", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_SHADOW_QUALITY", "Button")))
            {
                this.shadowQualityLabel.Text = Language.Read("CONFIG_STRING_SHADOW_QUALITY", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_SHADOW_TARGET", "Button")))
            {
                this.targetShadowLabel.Text = Language.Read("CONFIG_STRING_SHADOW_TARGET", "Button");
            }

            if (!string.IsNullOrEmpty(Language.Read("CONFIG_STRING_LANGUAGE", "Button")))
            {
                this.languageGroup.Text = Language.Read("CONFIG_STRING_LANGUAGE", "Button");
            }
        }

        private void InitializeConfiguration()
        {
        }

    }
}
