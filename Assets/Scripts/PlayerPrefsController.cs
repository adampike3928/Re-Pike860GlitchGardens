using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{
    const string MASTER_VOLUME_KEY = "master volume";
    const string DIFFICULTY_KEY = "difficulty";

    const float MIN_VOLUME = 0f;
    const float MAX_VOLUME = 1f;

    const float MIN_DIFFICULTY = 0f;
    const float MAX_DIFFICULTY = 2f;

    public static void SetMasterVolume(float fltvolume)
    {
        if (fltvolume >= MIN_VOLUME && fltvolume <= MAX_VOLUME)
        {
            Debug.Log("Master volume set to " + fltvolume);
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, fltvolume);
        }
        else
        {
            Debug.LogError("Master volume is out of tange");
        }



    }
    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }
    public static void SetDifficulty(float fltDifficulty)
    {
        if(fltDifficulty >= MIN_DIFFICULTY && fltDifficulty <= MAX_DIFFICULTY)
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, fltDifficulty);
        }
        else
        {
            Debug.LogError("DIfficulty setting is not in range");
        }
    }
    //sets an if statment to make sure MIN or MAX is existant
    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }
    //returning what is stored in difficulty key
}
