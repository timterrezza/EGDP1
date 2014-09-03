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
		if (timeObject > 45) {
			timeBetweenSpawns = 2f;
			teacherTimeBetweenSpawns = 5f;
		}
		else if (timeObject > 34) {
			timeBetweenSpawns = 1.5f;
			teacherTimeBetweenSpawns = 4f;
		}
		else if (timeObject > 26) {
			timeBetweenSpawns = 2f;
			teacherTimeBetweenSpawns = 3f;
		}
		else if (timeObject > 16) {
			timeBetweenSpawns = 0.8f;
			teacherTimeBetweenSpawns = 4f;
		}
		else if (timeObject > 10) {
			timeBetweenSpawns = 1.5f;
			teacherTimeBetweenSpawns = 3f;
		}
		else {
			timeBetweenSpawns = 0.8f;
			teacherTimeBetweenSpawns = 4f;
		}
		if (!gameOver) {
			timer += Time.deltaTime;
			teacherTimer += Time.deltaTime;
			if (timer > timeBetweenSpawns) {
				int spawnIndex = Random.Range(0, spawnPoints.Length);
				int goodChance = Random.Range (0, 20);
				if (goodChance == 0) {
					projectile = Resources.Load("Prefabs/goodProjectile");
				}
				else {
					projectile = Resources.Load("Prefabs/badProjectile");
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
