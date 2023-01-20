using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health;
    // Start is called before the first frame update
   
    public void dealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            //goining to die state
            DestroyObject();
        }
    }
    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
