﻿using UnityEngine;
using System.Collections;
using System;

public class WallGenerationScript : MonoBehaviour {

	public float spawnTime = 5f;		// The amount of time between each spawn.
	public float spawnDelay = 3f;		// The amount of time before spawning starts.
	public Transform enemyPrefab;

	private int gap;
	private int leftX;
	private System.Random rnd;
	
	void Start () {
		rnd = new System.Random ();
		gap = 14;
		leftX = -7;

		// Start calling the Spawn function repeatedly after a delay .
		InvokeRepeating("Spawn", spawnDelay, spawnTime);
	}
	
	void Spawn () {
		Instantiate(enemyPrefab, new Vector2(leftX, 7), transform.rotation);
		Instantiate(enemyPrefab, new Vector2(leftX + gap, 7), transform.rotation);

		leftX = rnd.Next (leftX - 1, leftX + 2);
	}
}