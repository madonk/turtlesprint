using UnityEngine;
using System.Collections;

public class WallGenerationScript : MonoBehaviour {

	public float spawnTime = 5f;		// The amount of time between each spawn.
	public float spawnDelay = 3f;		// The amount of time before spawning starts.
	public Transform enemyPrefab;
	
	void Start () {
		// Start calling the Spawn function repeatedly after a delay .
		InvokeRepeating("Spawn", spawnDelay, spawnTime);
	}
	
	void Spawn () {
		Instantiate(enemyPrefab, new Vector2(0, 4), transform.rotation);
	}
}
