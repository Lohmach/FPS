using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

    public GameObject marks;
    private RaycastHit rch;
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(0, 0, 1);
        if (Physics.Raycast(transform.position, transform.forward, out rch, 1500.0f))
        {
            if(rch.transform.tag == "Green")
            {
                Instantiate(marks, rch.point, Quaternion.identity);
            }
        }
        if (Physics.Raycast(transform.position, transform.forward, out rch, 1500.0f))
        {
            if (rch.transform.tag == "enemy")
            {
                global_variables.enemy1_hp -= 1;
            }
        }
        if (Physics.Raycast(transform.position, transform.forward, out rch, 1500.0f))
        {
            if (rch.transform.tag == "enemy1")
            {
                global_variables.enemy2_hp -= 1;
            }
        }
        if (Physics.Raycast(transform.position, transform.forward, out rch, 1500.0f))
        {
            if (rch.transform.tag == "enemy2")
            {
                global_variables.enemy3_hp -= 1;
            }
        }
    }
}
