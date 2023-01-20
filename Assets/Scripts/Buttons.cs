using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
//using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public GameObject defenderPrefab;
    private Buttons[] buttonArray;
    public static GameObject selectedDefender;
    // Start is called before the first frame update
    void Start()
    {
        buttonArray = FindObjectsOfType<Buttons>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        foreach(Buttons thisbutton in buttonArray)
        {
            thisbutton.GetComponent<SpriteRenderer>().color = Color.gray;    

        }
        Debug.Log(name + " pressed");
        GetComponent<SpriteRenderer>().color = Color.white;
        selectedDefender = defenderPrefab;
        Debug.Log(selectedDefender);
    }
}
