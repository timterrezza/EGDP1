using UnityEngine;
using System.Collections;

public class projectileSpawner : MonoBehaviour {
	GameObject[] spawnPoints;
	float timer;
	float timeBetweenSpawns;
	GameObject[] projectiles;
	public bool gameOver;
	Object projectile;
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
				if (spawnPoints[spawnIndex].name == "teacher") {
					projectile = Resources.Load("Prefabs/goodProjectile");
				}
				else {
					int goodChance = Random.Range (0, 7);
					if (goodChance == 0) {
						projectile = Resources.Load("Prefabs/goodProjectile");
					}
					else {
						projectile = Resources.Load("Prefabs/badProjectile");
					}
				}
				Instantiate(projectile, new Vector3(spawnPoints[spawnIndex].gameObject.transform.localPosition.x, spawnPoints[spawnIndex].gameObject.transform.localPosition.y,-0.1f),Quaternion.identity);
				timer = 0;
			}
		}
	}
}
