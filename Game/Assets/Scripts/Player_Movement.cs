using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour {


	public float speed = 20.0f;


	// Update is called once per frame
	void Update () {
		if(Input.GetKey (KeyCode.W))	{
			transform.position += Vector3.forward * Time.deltaTime;
		}
		if(Input.GetKey (KeyCode.A))	{
			transform.position += Vector3.left * Time.deltaTime;
		}
		if(Input.GetKey (KeyCode.S))	{
			transform.position += Vector3.back * Time.deltaTime;
		}
		if(Input.GetKey (KeyCode.D))	{
			transform.position += Vector3.right * Time.deltaTime;
		}
	}

}