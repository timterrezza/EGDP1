using UnityEngine;
using System.Collections;

public class Timer_Code : MonoBehaviour {

	public float time_limit = 10f;
	public bool game_over = false;

	void Start()	{
		InvokeRepeating("timeDecrease", 1.0f, 1.0f);
	}

	void Update () {
		if(time_limit > 0)
			guiText.text = time_limit + " Seconds left";
		else
			guiText.text = "TIME'S UP!";


		//End of Game
		if(time_limit <= 0 && game_over == false)	{
			CancelInvoke();
			Debug.Log("GAME OVER");
			game_over = true;
		}

	}

	void timeDecrease()	{
		time_limit--;
		Debug.Log (time_limit);
	}

}
