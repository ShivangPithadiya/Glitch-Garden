using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    public float speed, damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health health = collision.gameObject.GetComponent<Health>();
        Attackers attackers = collision.gameObject.GetComponent<Attackers>();
        if (collision.gameObject.CompareTag("bulletCollider"))
        {
            Destroy(gameObject);
        }
        //if(collision.gameObject.CompareTag("fox") || collision.gameObject.CompareTag("lizard"))
        
        if (health && attackers)
        {
            health.dealDamage(5);
            Destroy(gameObject);
        }

        
    }
}
