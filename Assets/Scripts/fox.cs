using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Attackers))]
public class fox : MonoBehaviour
{
    private Animator anim;
    private Attackers attackers;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        attackers = gameObject.GetComponent<Attackers>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject obj = collision.gameObject;
        if (!obj.GetComponent<Defenders>())
        {
            return;
        }
        if (obj.CompareTag("stone"))
        {
            anim.SetTrigger("jumpTriggered");
        }
        else
        {
            anim.SetBool("isAttacking", true);
            attackers.attack(obj);
        }

        Debug.Log("Fox collided with " + collision);
    }
}
