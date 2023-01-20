using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Defenders : MonoBehaviour
{
    public int startCost ;
    private starDisplay stardisplay;
   
    private void Start()
    {
        stardisplay = FindObjectOfType<starDisplay>();
    }
    public void addStarts(int amount)
    {
        stardisplay.addStar(amount);
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    Debug.Log(name + "triggered");
    //}
}
