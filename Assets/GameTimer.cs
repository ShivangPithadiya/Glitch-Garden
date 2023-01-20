using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    MusicManager musicmanager;
    public float levelSeconds;
    public GameObject buttons;
    public GameObject lane_1;
    public GameObject lane_2;
    public GameObject lane_3;
    public GameObject fox;
    public GameObject lizard;
    public GameObject stone;
    public GameObject star;


    public GameObject winImage;

    private LevelManager levelmanager;
    private AudioSource levelcompleteaudio;
   // public AudioSource levelAudio;
    private bool isEndOfLevel = true;
    //public GameObject winlabel;
    //private float secondleft;

    private Slider gameTimer;

    private void Awake()
    {
        Time.timeScale = 1;
        //levelAudio.Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        musicmanager = FindObjectOfType<MusicManager>();
        gameTimer = gameObject.GetComponent<Slider>();
        levelcompleteaudio = gameObject.GetComponent<AudioSource>();
        levelmanager = FindObjectOfType<LevelManager>();

        //secondleft = levelSeconds;

    }

    // Update is called once per frame
    void Update()
    {
        
        gameTimer.value = Time.timeSinceLevelLoad / levelSeconds;
        if((Time.timeSinceLevelLoad) >= levelSeconds && isEndOfLevel)
        {
            //Time.timeScale = 0;
            
            levelcompleteaudio.Play();
            fox.SetActive(false);
            lizard.SetActive(false);
            star.SetActive(false);
            stone.SetActive(false);
            lane_1.SetActive(false);
            lane_2.SetActive(false);
            lane_3.SetActive(false);
            buttons.SetActive(false);
            winImage.SetActive(true);
            Invoke("loadNextLevel", levelcompleteaudio.clip.length);
            print("level complete........");
            isEndOfLevel = false;

        }
    }
    void loadNextLevel()
    {
        levelmanager.LoadLevel("03awin");
        fox.SetActive(true);
        lizard.SetActive(true);
        star.SetActive(true);
        stone.SetActive(true);
        buttons.SetActive(true);
        lane_1.SetActive(true);
        lane_2.SetActive(true);
        lane_3.SetActive(false);
        winImage.SetActive(false);

    }

}
