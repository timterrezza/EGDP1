using UnityEngine;
using System.Collections;

public class Timer_Code : MonoBehaviour {

	public float time_limit = 10f;
	public bool game_over = false;

	void Start()	{
		InvokeRepeating("timeDecrease", 1.0f, 1.0f);
	}

	void Update () {
		GameObject foo = GameObject.Find("spawnMaster");
		projectileSpawner spawner = foo.GetComponent<projectileSpawner>();

		if(time_limit > 0)
			guiText.text = time_limit + " Seconds left";
		else {
				spawner.gameOver = true;
				guiText.text = "TIME'S UP!";
		}

		//End of Game
		if(time_limit <= 0 && game_over == false)	{
			CancelInvoke();
			game_over = true;
		}

	}

	void timeDecrease()	{
		time_limit--;
	}

}
