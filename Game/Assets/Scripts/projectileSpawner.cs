using UnityEngine;
using System.Collections;

public class projectileSpawner : MonoBehaviour {
	GameObject[] spawnPoints;
	float timer;
	float timeBetweenSpawns;
	GameObject[] projectiles;
	public bool gameOver;
	Object projectile;
	bool teacherSpawn;
	int teacherChance;
	GameObject teacher;
	// Use this for initialization
	void Start () {
		teacher = GameObject.Find("teacher");
		gameOver = false;
		spawnPoints = GameObject.FindGameObjectsWithTag("spawnPoint");
		timer = 0;
		timeBetweenSpawns = 2.5f;
		teacherSpawn = false;
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
					int goodChance = Random.Range (0, 5);
					if (goodChance == 0) {
						projectile = Resources.Load("Prefabs/goodProjectile");
					}
					else {
						projectile = Resources.Load("Prefabs/badProjectile");
					}
				}
				teacherChance = Random.Range(0, 4);
				if (teacherChance == 0) {
					teacherSpawn = true;
					projectile = Resources.Load("Prefabs/goodProjectile");
				}
				if (teacherSpawn) {
					Instantiate(projectile, new Vector3(teacher.gameObject.transform.localPosition.x, teacher.gameObject.transform.localPosition.y,-0.1f),Quaternion.identity);
				}
				else {
					Instantiate(projectile, new Vector3(spawnPoints[spawnIndex].gameObject.transform.localPosition.x, spawnPoints[spawnIndex].gameObject.transform.localPosition.y,-0.1f),Quaternion.identity);
				}
				timer = 0;
				teacherSpawn = false;
			}
		}
	}
}
