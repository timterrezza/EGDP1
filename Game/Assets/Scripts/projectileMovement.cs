using UnityEngine;
using System.Collections;

public class projectileMovement : MonoBehaviour {
	public int spawnPattern;
	float radians;
	float speed;
	// Use this for initialization
	void Start () {
		spawnPattern = Random.Range (1,4);
		radians = 0f;
		speed = 0.1f;
	}
	
	// Update is called once per frame
	void Update () {
		if(spawnPattern == 1) {
			transform.localPosition += new Vector3(1.5f * speed * Mathf.Cos(radians), -2f * speed, 0f);
			radians += 0.1f;
		}
		else if(spawnPattern == 2) {
			transform.localPosition += new Vector3(0,-2f * speed);
		}
		else {
			transform.localPosition += new Vector3(2f * speed * Mathf.Cos(radians), -1f * speed, 0f);
			radians += 0.1f;
		}
		if (transform.localPosition.y < -15) {
			Destroy(gameObject);
		}

	}
}
