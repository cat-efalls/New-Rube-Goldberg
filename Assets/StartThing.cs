using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//put this on the trapdoor
public class StartThing : MonoBehaviour {

	public Rigidbody trapDoor;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			trapDoor.constraints = RigidbodyConstraints.None;
		}
	}
}
