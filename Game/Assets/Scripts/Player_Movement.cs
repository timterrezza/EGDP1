using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour {

	public GameObject player;
	public float speed = 6.0f;

	public float max_x = 9.7f;
	public float min_x = -9.5f;

	public float max_y = -2f;
	public float min_y = -9.5f;



	// Update is called once per frame
	void Update () {
	 	if(Input.GetKey (KeyCode.W)){
			if (transform.position.y < max_y) {
				transform.position += new Vector3(0,1 * Time.deltaTime * speed,0);
			}
		}
		if(Input.GetKey (KeyCode.A)){
			if (transform.position.x > min_x) {
				transform.position += new Vector3(-1 * Time.deltaTime * speed,0,0);
			}
		}
		if(Input.GetKey (KeyCode.S)){
			if (transform.position.y > min_y) {
				transform.position += new Vector3(0,-1 * Time.deltaTime * speed,0);
			}
		}
		if(Input.GetKey (KeyCode.D)){
			if (transform.position.x < max_x) {
				transform.position += new Vector3(1 * Time.deltaTime * speed,0,0);
			}
		}
	}

}