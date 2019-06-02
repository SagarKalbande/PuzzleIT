using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockBehavior : MonoBehaviour {

    public bool horizontal_b;
    public float speed = 0.3f;
    private bool randomNo;
    // Use this for initialization
    void Start () {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(Random.value, Random.value, Random.value, 1);

        randomNo = (Random.value > 0.85f);

        if ((Random.value > 0.5f))
        {
            horizontal_b = true ;
            // gameObject.transform.rotation = gameObject.transform.rotation + new Vector3(0.0f, 0.0f, 90.0f);
            Quaternion target = Quaternion.Euler(0, 0, 90.0f);

            // Dampen towards the target rotation
            gameObject.transform.rotation = gameObject.transform.rotation * target;// Quaternion.Slerp(transform.rotation, target, Time.deltaTime);
        }
        if (randomNo)
        {
            Invoke("Rotate", 0.5f);
        }
    }

    void Rotate()
    {
        horizontal_b = !horizontal_b;
        Quaternion target = Quaternion.Euler(0, 0, 90.0f);
        // Dampen towards the target rotation
        gameObject.transform.rotation = gameObject.transform.rotation * target;// Quaternion.Slerp(transform.rotation, target, Time.deltaTime);    }
    }                                                                         // Update is called once per frame
        void Update ()
    {
        if(randomNo)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(Random.value, Random.value, Random.value, 1);
        }
        gameObject.transform.position = gameObject.transform.position + new Vector3(-speed, 0.0f, 0.0f);
	}

}
