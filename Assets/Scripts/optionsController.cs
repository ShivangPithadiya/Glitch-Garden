using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class optionsController : MonoBehaviour
{
    public Slider volumeSlider;
    public Slider DifficultySlider;
    public LevelManager levelManager;
    private MusicManager musicmanager;
    // Start is called before the first frame update
    void Start()
    {
        musicmanager = FindObjectOfType<MusicManager>();
        volumeSlider.value = playerPrefsManager.GetMasterVolume();
        DifficultySlider.value = playerPrefsManager.GetDifficulty();
        
    }

    // Update is called once per frame
    void Update()
    {
        musicmanager.SetVolume(volumeSlider.value); 

    }
    public void saveAndExit()
    {
        playerPrefsManager.SetMasterVolume(volumeSlider.value);
        playerPrefsManager.SetDifficulty(DifficultySlider.value);
        levelManager.LoadLevel("01astart");
    }
    public void setDefaults()
    {
        volumeSlider.value = 0.8f;
        DifficultySlider.value = 2f;
    }
}
