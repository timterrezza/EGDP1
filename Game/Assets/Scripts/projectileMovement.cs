using UnityEngine;
using System.Collections;

public class projectileMovement : MonoBehaviour {
	public int spawnPattern;
	float radians;
	// Use this for initialization
	void Start () {
		spawnPattern = Random.Range (1,4);
		radians = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		if(spawnPattern == 1) {
			transform.localPosition += new Vector3(0.2f * Mathf.Cos(radians), -0.1f);
			radians += 0.1f;
		}
		else if(spawnPattern == 2) {
			transform.localPosition += new Vector3(0,-0.2f);
		}
		else {
			transform.localPosition += new Vector3(0,-0.3f);
		}

	}
}
