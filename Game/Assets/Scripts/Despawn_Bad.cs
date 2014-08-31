using UnityEngine;
using System.Collections;

public class Despawn_Bad : MonoBehaviour {

	private void OnCollisionEnter(Collision c) 
	{
		if(c.gameObject.name == "Bad Thing") {
			Destroy(c.gameObject);
			Debug.Log ("HNGGGGG");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
