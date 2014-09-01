using UnityEngine;
using System.Collections;

public class teacherMovement : MonoBehaviour {
	float xspeed;
	float timer;
	float timeBetweenMovements;
	// Use this for initialization
	void Start () {
		xspeed = 0.1f;
		timer = 0;
		timeBetweenMovements = 2.5f;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > timeBetweenMovements) {
			timer = 0;
			timeBetweenMovements = Random.Range(2,4);
			xspeed = -xspeed;
		}
		if (transform.position.x > 9.5) {
			xspeed = -0.1f;
		}
		if (transform.position.x < -9.5) {
			xspeed = 0.1f;
		}
		transform.localPosition += new Vector3(xspeed, 0);
	}
}
