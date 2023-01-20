using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GridCollider : MonoBehaviour
{
    starDisplay stardisplay;
    private void OnMouseDown()
    {
        GameObject defender = Buttons.selectedDefender;
        int defenderCost = defender.GetComponent<Defenders>().startCost;
        if (stardisplay.useStar(defenderCost) == starDisplay.status.SUCCESS)
        {
            Instantiate(Buttons.selectedDefender, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.Log("insufficiant star to spawnning...............");
        }

        //GetComponent<SpriteRenderer>().sortingOrder = 2;
    }


    // Start is called before the first frame update
    void Start()
    {
        stardisplay = FindObjectOfType<starDisplay>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
