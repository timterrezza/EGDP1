using UnityEngine;
using System.Collections;

public class distractionSpawner : MonoBehaviour {

	float timer;
	float timeBetweenSpawns;
	Object distraction;

	// Use this for initialization
	void Start () {
		timer = 0;
		timeBetweenSpawns = 10f;
		distraction = Resources.Load("Prefabs/distraction");
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > timeBetweenSpawns) {
			Instantiate (distraction, new Vector3(-12f, 12f, -10f), Quaternion.identity);
			timer = 0;
		}
	}
}
