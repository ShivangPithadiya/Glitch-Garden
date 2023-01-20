using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPrefsManager : MonoBehaviour
{
    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFFICULTY_KEY = "difficulty";
    const string LEVEL_KEY = "level_unlocked_";

    public static void SetMasterVolume(float volume)
    {
        if(volume>=0f && volume <= 1f)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("master volume outof range");
        }
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }
    public static void UnlockLevel(int level)
    {
        if (level <= Application.levelCount - 1)
        {
            PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1);
        }
        else
        {
            Debug.LogError("trying to unlock level not in build order");
        }
    }
    public static bool isLevelUnlocked(int level)
    {
        int levelValue = PlayerPrefs.GetInt(LEVEL_KEY + level.ToString());
        bool IsLevelUnlocked = ( levelValue == 1 );

        if (level <= Application.levelCount - 1)
        {
            return IsLevelUnlocked;
        }
        else
        {
            Debug.LogError("trying to query level not in build order");
            return false;
        }
    }
    public static void SetDifficulty(float difficulty)
    {
        if(difficulty>=0f && difficulty <= 1f)
        {
            PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficulty);
        }
        else
        {
            Debug.LogError("difficulty outof Range");
        }
    }
    public static float GetDifficulty()
    {
        return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
    }
}
