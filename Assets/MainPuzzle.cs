using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPuzzle : MonoBehaviour {

    public bool horizontal;
    public GameObject Cam;
    public GameObject fx;
	// Use this for initialization
	void Start ()
    {
        Cam.GetComponent<CameraShake>().ShakeIt = true;
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown("space"))
        {
            horizontal = !horizontal;
           // gameObject.transform.rotation = gameObject.transform.rotation + new Vector3(0.0f, 0.0f, 90.0f);
            Quaternion target = Quaternion.Euler(0, 0, 90.0f);

            // Dampen towards the target rotation
            gameObject.transform.rotation = gameObject.transform.rotation*target;// Quaternion.Slerp(transform.rotation, target, Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        bool fit = other.gameObject.GetComponent<blockBehavior>().horizontal_b == horizontal;
        if (fit == false)
        {
            Cam.GetComponent<CameraShake>().ShakeIt = true;
            fx.GetComponent<ParticleSystem>().startColor = other.GetComponent<SpriteRenderer>().color;
            Instantiate(fx, other.gameObject.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
        }



    }

}
