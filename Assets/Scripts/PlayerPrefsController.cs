using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{
    const string conMASTER_VOLUME_KEY = "master volume";
    const string conDIFFICULTY_KEY = "difficulty";

    const float MIN_VOLUME = 0f;
    const float MAX_VOLUME = 1f;

    public static void SetMasterVolume(float fltvolume)
    {
        if (fltvolume >= MIN_VOLUME && fltvolume <= MAX_VOLUME)
        {
            Debug.Log("Master volume set to " + fltvolume);
            PlayerPrefs.SetFloat(conMASTER_VOLUME_KEY, fltvolume);
        }
        else
        {
            Debug.LogError("Master volume is out of tange");
        }



    }
    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(conMASTER_VOLUME_KEY);
    }




}
