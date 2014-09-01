using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour {


	public float speed = 4.0f;

	public float max_x = 6.3680293f;
	public float min_x = -6.646746f;

	public float max_z = -2.0f;
	public float min_z = -6.754216f;



	// Update is called once per frame
	void Update () {

	 	if(Input.GetKey (KeyCode.W))	{
			transform.position += Vector3.forward * Time.deltaTime * speed;
		}

		if(Input.GetKey (KeyCode.A))	{
			transform.position += Vector3.left * Time.deltaTime * speed;
		}
		if(Input.GetKey (KeyCode.S))	{
			transform.position += Vector3.back * Time.deltaTime * speed;
		}
		if(Input.GetKey (KeyCode.D))	{
			transform.position += Vector3.right * Time.deltaTime * speed;
		}
	}

}