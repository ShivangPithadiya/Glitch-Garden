using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Attackers : MonoBehaviour
{
    //[Range(-1f, 1.5f)]
    public float seenEverySeconds;

    private float currentSpeed;
    private GameObject curruntTargate;
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        //Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
        //rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
        if (!curruntTargate)
        {
            anim.SetBool("isAttacking",false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(name + "triggered");
    }
    public void setSpeed(float speed)
    {
        currentSpeed = speed;
    }
    public void strikeCurruntTargate(float Damage)
    {
        if (curruntTargate)
        {
            Health _health = curruntTargate.GetComponent<Health>();
            if (_health)
            {
                _health.dealDamage(Damage);
            }
        }
        Debug.Log(name + "caused Damage " + Damage);
    }
    public void attack(GameObject obj)
    {
        curruntTargate = obj;
    }
}
