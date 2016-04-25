using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public GameObject objectToSpawn;
	public float spawnTime = 5f;
	public int maxEnemies;

	private int _nrOfEnemiesSpawned;
	private Vector3 spawnPoint;

	void Update()
	{
		if (_nrOfEnemiesSpawned <= 30) 
		{
			spawnEnemy ();
		}
	}

	void spawnEnemy()
	{
		spawnPoint.x = Random.Range (-60,60);
		spawnPoint.z = Random.Range (-60,60);

		Instantiate (objectToSpawn, spawnPoint, Quaternion.identity);
		_nrOfEnemiesSpawned++;
	}
}
