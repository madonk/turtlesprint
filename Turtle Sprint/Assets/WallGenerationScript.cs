using UnityEngine;
using System.Collections;
using System;

public class WallGenerationScript : MonoBehaviour {

	public float spawnTime = 5f;		// The amount of time between each spawn.
	public float spawnDelay = 3f;		// The amount of time before spawning starts.
	public Transform enemyPrefab;

	private double gap;
	private int prevMid;
	private System.Random rnd;

	private double screenLeft;
	private double screenRight;
	private double screenTop;
	private double screenBottom;

	private double blockWidth;
	private double blockHeight;
	
	void Start () {
		rnd = new System.Random ();

		Vector2 screenCoords = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
		screenRight = screenCoords.x;
		screenLeft = - screenRight;
		screenTop = screenCoords.y;
		screenBottom = -screenTop;

		blockWidth = enemyPrefab.collider2D.bounds.extents.x * 2;
		blockHeight = enemyPrefab.collider2D.bounds.extents.y * 2;

		gap = 4;
		prevMid = 0;

		// Start calling the Spawn function repeatedly after a delay .
		InvokeRepeating("Spawn", spawnDelay, spawnTime);
	}
	
	void Spawn () {
		double offset = gap / 2 + blockWidth / 2;

		Instantiate(enemyPrefab, new Vector2((float) (prevMid - offset), 7), transform.rotation);
		Instantiate(enemyPrefab, new Vector2((float) (prevMid + offset), 7), transform.rotation);

		double maxOffset = gap / 2 + blockWidth / 2 - 0.1 * blockWidth;

		int leftOffset = prevMid - 1;
		leftOffset = Math.Max (leftOffset, - (int) maxOffset);
		int rightOffset = prevMid + 1;
		rightOffset = Math.Min (rightOffset, (int) maxOffset);

		prevMid = rnd.Next (leftOffset, rightOffset + 1);
	}
}
