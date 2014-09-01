using UnityEngine;
using System.Collections;

public class projectileSpawner : MonoBehaviour {
	public GameObject[] spawnPoints;
	public float timer;
	public float timeBetweenSpawns;
	public GameObject[] projectiles;
	public bool gameOver;
	// Use this for initialization
	void Start () {
		gameOver = false;
		spawnPoints = GameObject.FindGameObjectsWithTag("spawnPoint");
		timer = 0;
		timeBetweenSpawns = 2.5f;
	}
	
	// Update is called once per frame
	void Update () {
		if (!gameOver) {
			timer += Time.deltaTime;
			if (timer > timeBetweenSpawns) {
				int spawnIndex = Random.Range(0, spawnPoints.Length);
				Object projectile = Resources.Load("Prefabs/projectile");
				Instantiate(projectile, spawnPoints[spawnIndex].gameObject.transform.position, Quaternion.identity);
				timer = 0;
			}
		}
	}
}
