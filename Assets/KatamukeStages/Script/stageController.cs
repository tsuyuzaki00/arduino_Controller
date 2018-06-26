using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stageController : MonoBehaviour {

    int x, y, z;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            z += 2;
        }
        if (Input.GetKey(KeyCode.D))
        {
            z += -2;
        }
        if (Input.GetKey(KeyCode.W))
        {
            x += 2;
        }
        if (Input.GetKey(KeyCode.S))
        {
            x += -2;
        }

        transform.rotation = Quaternion.Euler(x, y, z);
    }
}
