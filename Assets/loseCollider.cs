using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loseCollider : MonoBehaviour
{
    private LevelManager levelmanager;
    private int enemycounter =5;
    // Start is called before the first frame update
    void Start()
    {
        levelmanager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(enemycounter == 0)
        {
            levelmanager.LoadLevel("03blose");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("lizard") || collision.gameObject.CompareTag("fox"))
        {
            enemycounter--;
            Destroy(collision.gameObject);
            
        }
    }
   
}
