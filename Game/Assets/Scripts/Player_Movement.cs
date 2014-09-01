using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour {

	public GameObject player;
	public float speed = 4.0f;

	public float max_x = 9.7f;
	public float min_x = -9.5f;

	public float max_y = -6f;
	public float min_y = -9.5f;



	// Update is called once per frame
	void Update () {
		player = GameObject.Find("Player");
		Debug.Log ("X: " + player.transform.position.x);
		Debug.Log ("Y: " + player.transform.position.y);
	 	if(Input.GetKey (KeyCode.W))	{
			transform.position += new Vector3(0,1 * Time.deltaTime * speed,0);
		}

		if(Input.GetKey (KeyCode.A))	{
			transform.position += new Vector3(-1 * Time.deltaTime * speed,0,0);
		}
		if(Input.GetKey (KeyCode.S))	{
			transform.position += new Vector3(0,-1 * Time.deltaTime * speed,0);
		}
		if(Input.GetKey (KeyCode.D))	{
			transform.position += new Vector3(1 * Time.deltaTime * speed,0,0);
		}
	}

}