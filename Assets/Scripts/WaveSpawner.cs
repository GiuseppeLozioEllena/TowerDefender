using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour {

    public Transform enemyPrefab;
    public float timeBetwenWaves;
    private float countdown;
    private int EnemyNumber=1;
    public float timeSpawn = 1.25f;
    public int MaxNumberForWay = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (countdown <= 0)
        {

            StartCoroutine(SpawnWave());
            countdown = timeBetwenWaves;
        }
        countdown -= Time.deltaTime;
	}

    IEnumerator SpawnWave()
    {
        for (int i= 0; i < EnemyNumber; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(timeSpawn);
        }
        
        if(EnemyNumber<6)
            EnemyNumber++;

        if (EnemyNumber == MaxNumberForWay)
            EnemyNumber = 1;

    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab);
    }

}
