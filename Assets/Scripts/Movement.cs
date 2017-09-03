using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Movement : MonoBehaviour {

	void Update () {

        CheckLeft();
        CheckRight();
	}

    void CheckLeft()
    {
        Vector3 pos = gameObject.transform.position;
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 newpos = new Vector3(Convert.ToSingle(pos.x - 0.1), pos.y, pos.z);
            gameObject.transform.SetPositionAndRotation(newpos, Quaternion.identity);
        }
    }

    void CheckRight()
    {
        Vector3 pos = gameObject.transform.position;
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 newpos = new Vector3(Convert.ToSingle(pos.x + 0.1), pos.y, pos.z);
            gameObject.transform.SetPositionAndRotation(newpos, Quaternion.identity);
        }
    }









}
