using UnityEngine;
using System.Collections;

public class distractionMovement : MonoBehaviour {

	float xSpeed;
	float ySpeed;

	// Use this for initialization
	void Start () {
		xSpeed = 0.1f;
		ySpeed = -0.1f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition += new Vector3(xSpeed,ySpeed);
	}
}
