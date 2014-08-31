using UnityEngine;
using System.Collections;

public class Grading : MonoBehaviour {
	

	// Update is called once per frame
	void Update () {

		//if(game_over == true)
		GameObject score = GameObject.Find("Score");
		Score_Code foo = score.GetComponent<Score_Code>();

		if(foo.score == 100)
			guiText.text = "Grade: A+! Great job!";
		else if(foo.score > 89)
			guiText.text = "Grade: A!";
		else if(foo.score > 79)
			guiText.text = "Grade: B!";
		else if(foo.score > 69)
			guiText.text = "Grade: C!";
		else if(foo.score > 59)
			guiText.text = "Grade: D!";
		else
			guiText.text = "Grade: F! Boooooo.";

	}
}
