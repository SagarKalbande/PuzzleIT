using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlock : MonoBehaviour {

    public GameObject block;
    float speed1 = 0.1f;
    // Use this for initialization
    void Start ()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        //Instantiate(block, gameObject.transform.position , Quaternion.identity);
        Invoke("respawn", 2f);
    }

     //this will call respawn fun after 2 sec

    void respawn()
    {
        var Spawned = Instantiate(block, gameObject.transform.position, Quaternion.identity);
        speed1 = speed1 + 0.02f; ;
        if (speed1 > 0.6f)
        { speed1 = 0.6f; }
        Spawned.GetComponent<blockBehavior>().speed = speed1;
        Invoke("respawn", 1f);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
