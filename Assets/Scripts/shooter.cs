using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    private Animator anim;
    private AttackerSpawnner myLaneSpawnner;
    public GameObject projecttile,gun;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    public void Fire()
    {
        GameObject newProjectile = Instantiate(projecttile,gun.transform.position,Quaternion.identity) as GameObject;
        //projecttile.transform.parent = projectileParant.transform;
    }
    private void Update()
    {
        if (isAttackerAheadLane())
        {
            anim.SetBool("isAttacking", true);
        }
        else
        {
            anim.SetBool("isAttacking", false);

        }
    }
    public void setMySpawnnerlane()
    {

        AttackerSpawnner[] spawnnerArray = FindObjectsOfType<AttackerSpawnner>();
        foreach(AttackerSpawnner spawnner in spawnnerArray)
        {
            if (spawnner.transform.position.y == transform.position.y)
            {

            }
        }
    }
    public bool isAttackerAheadLane()
    {
        return true;
    }
}
