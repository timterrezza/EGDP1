using UnityEngine;
using System.Collections;

public class Basic_Enemy : MonoBehaviour {

	public float speed = 1.0f;

	private void OnCollisionEnter(Collision c) 
	{
		if(c.gameObject.name == "Player") {
			GameObject.Destroy (gameObject);
			Debug.Log ("HNGGGGG");
		}
	}



	// Update is called once per frame
	void Update () {
		transform.position += Vector3.back * Time.deltaTime;
		Debug.Log (Time.deltaTime);
	}

}
