using UnityEngine;
using System.Collections;

public class projectileMovement : MonoBehaviour {
	public int spawnPattern;
	float radians;
	float speed;
	float xSpeed;
	float ySpeed;
	// Use this for initialization
	void Start () {
		spawnPattern = Random.Range (1,5);
		radians = 0f;
		xSpeed = 0.1f;
		ySpeed = 0.1f;
	}
	
	// Update is called once per frame
	void Update () {
		if(spawnPattern == 1) {
			transform.localPosition += new Vector3(1.5f * xSpeed * Mathf.Cos(radians), -2f * ySpeed, 0f);
			radians += 0.1f;
		}
		else if(spawnPattern == 2) {
			transform.localPosition += new Vector3(0,-2f * ySpeed);
		}
		else if(spawnPattern == 3) {
			transform.localPosition += new Vector3(2f * xSpeed * Mathf.Cos(radians), -1f * ySpeed, 0f);
			radians += 0.1f;
		}
		else {
			transform.localPosition += new Vector3(2f * xSpeed, -1f * ySpeed, 0f);
			if (transform.localPosition.x < -9.5) {
				xSpeed = -xSpeed;
			}
			if (transform.localPosition.x > 9.5) {
				xSpeed = -xSpeed;
			}
		}
		if (transform.localPosition.y < -15) {
			Destroy(gameObject);
		}

	}
}
