using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class L10nSetting : MonoBehaviour
{
    public void SetToEnglish()
    {
        Debug.Log("set to English");
   LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[0];
    }
public void SetToFrench()
    {
        Debug.Log("set to French");
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[1];
    }
}
