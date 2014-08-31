using UnityEngine;
using System.Collections;

public class Basic_Enemy : MonoBehaviour {

	public float speed = 1.0f;

	// Update is called once per frame
	void Update () {
		transform.position += Vector3.back * Time.deltaTime;
	}

}
