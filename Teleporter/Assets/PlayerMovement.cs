using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("d")) {
			rb.AddForce (2f, 0f, 0f);
		}
		if (Input.GetKey ("a")) {
			rb.AddForce (-2f, 0f, 0f);
		}
	}
}
