using UnityEngine;
using System.Collections;

public class projectileSpawner : MonoBehaviour {
	float timer;
	float teacherTimer;
	float timeBetweenSpawns;
	float teacherTimeBetweenSpawns;

	GameObject[] spawnPoints;
	GameObject[] projectiles;

	public bool gameOver;
	Object projectile;
	GameObject teacher;

	float timeObject;

	// Use this for initialization
	void Start () {
		teacher = GameObject.Find("teacher");
		gameOver = false;
		spawnPoints = GameObject.FindGameObjectsWithTag("spawnPoint");
		timer = 0;
		timeBetweenSpawns = 2.5f;
		teacherTimer = 0;
		teacherTimeBetweenSpawns = 3.5f;

		Debug.Log (timeObject);
	}
	
	// Update is called once per frame
	void Update () {
		timeObject = GameObject.Find("Timer").GetComponent<Timer_Code>().time_limit;
		if (timeObject > 40) {
			timeBetweenSpawns = 4f;
			teacherTimeBetweenSpawns = 4.5f;
		}
		else if (timeObject > 30) {
			timeBetweenSpawns = 3f;
			teacherTimeBetweenSpawns = 3.5f;
		}
		else if (timeObject > 20) {
			timeBetweenSpawns = 2.5f;
			teacherTimeBetweenSpawns = 3f;
		}
		else if (timeObject > 15) {
			timeBetweenSpawns = 1f;
			teacherTimeBetweenSpawns = 1f;
		}
		else if (timeObject > 8) {
			timeBetweenSpawns = 2.5f;
			teacherTimeBetweenSpawns = 3f;
		}
		else {
			timeBetweenSpawns = 1f;
			teacherTimeBetweenSpawns = 1f;
		}
		if (!gameOver) {
			timer += Time.deltaTime;
			teacherTimer += Time.deltaTime;
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
				Instantiate(projectile, new Vector3(spawnPoints[spawnIndex].gameObject.transform.localPosition.x, spawnPoints[spawnIndex].gameObject.transform.localPosition.y,-0.1f),Quaternion.identity);
				timer = 0;
			}
			if (teacherTimer > teacherTimeBetweenSpawns) {
				projectile = Resources.Load("Prefabs/goodProjectile");
				Instantiate(projectile, new Vector3(teacher.gameObject.transform.localPosition.x, teacher.gameObject.transform.localPosition.y,-0.1f),Quaternion.identity);
				teacherTimer = 0;
			}
		}
	}
}
