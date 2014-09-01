using UnityEngine;
using System.Collections;

public class Despawn_NPC : MonoBehaviour {


	private void OnCollisionEnter(Collision c) 
	{
		if(c.gameObject.tag == "bad") {
			Destroy(c.gameObject);
			GameObject score = GameObject.Find("Score");
			Score_Code foo = score.GetComponent<Score_Code>();
			foo.score -= 5;
			if(foo.score < 0)
				foo.score = 0;
		}
		if(c.gameObject.tag == "good")	{
			Destroy (c.gameObject);
			GameObject score = GameObject.Find("Score");
			Score_Code foo = score.GetComponent<Score_Code>();
			foo.score += 5;
			if(foo.score > 100)
				foo.score = 100;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
