using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) //when space is pressed it activates the kick
        {
            gameObject.GetComponent<Rigidbody>().AddForce(0, 300.0f, 1000.0f); //gives a force that simulates a kick
        }

        if (Input.GetKeyDown("return")) //reset to original position and velocity
        {
            gameObject.transform.position = new Vector3(-0.17f, 1.6f, -6.7f);
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 0.0f, 0.0f);
        }
    }
}

