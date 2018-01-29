using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 move = Vector3.zero;
		float speed = 0.05f;
		if (Input.GetKey (KeyCode.RightArrow)) {
			move = Vector3.right;
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			move = Vector3.left;
		}
		transform.position = move * speed + gameObject.transform.position;

        
	}
    void OnMouseDown()
    {

        //float degrees = 90;
        //Vector3 rotate = new Vector3(degrees, 0, 0);

        //transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime);
		gameObject.transform.Rotate (Vector3.right, 20.0f);


    }
}
