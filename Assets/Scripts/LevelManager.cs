using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    public float autoLoadNextLevelAfter;

    private void Start()
    {
        if(autoLoadNextLevelAfter == 0)
        {
            Debug.Log("Level Auto LOad Desable");
        }
        else
        {
            Invoke("nextLevel", autoLoadNextLevelAfter);

        }
    }

    public void LoadLevel(string name)
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Next Level Loaded" + name);
        Application.LoadLevel(name);
    }
    public void QuitGame()
    {
        Debug.Log("Quit Level");
        Application.Quit();
    }

    
    public void nextLevel()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        Application.LoadLevel(Application.loadedLevel + 1);
    }
}
