using UnityEngine;
using System.Collections;

public class Score_Code : MonoBehaviour {

	public int score = 80;
	
	// Update is called once per frame
	void Update () {
		guiText.text = "Score: " + score;
	}
}
