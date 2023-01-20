using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawnner : MonoBehaviour
{
    public GameObject[] AttackerPrefabArrays;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject thisAttacker in AttackerPrefabArrays)
        {
            if (isTimeToSpawn(thisAttacker))
            {
                spawn(thisAttacker);
            }
        }
    }
    public void spawn(GameObject myGameObject)
    {
        GameObject myAttacker = Instantiate(myGameObject);
        myAttacker.transform.parent = transform;
        myAttacker.transform.position = transform.position;
    }
    public bool isTimeToSpawn(GameObject attckerGameObject)
    {
        Attackers attacker = attckerGameObject.GetComponent<Attackers>();
        float meanSpawnDelay = attacker.seenEverySeconds;
        float spawnPerSecond = 1 / meanSpawnDelay;

        if (Time.deltaTime > meanSpawnDelay)
        {

        }
        float theshold = spawnPerSecond * Time.deltaTime/3;
        return Random.value < theshold;
       
    }
}
