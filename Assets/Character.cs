using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InvokeRepeating("ChangeRotation", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * Time.deltaTime * 10);
	}

	void ChangeRotation(){


		transform.Rotate(0, 90, 0);

	}
}
