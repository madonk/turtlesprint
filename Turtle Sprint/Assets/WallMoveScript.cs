using UnityEngine;
using System.Collections;

public class WallMoveScript : MonoBehaviour {

	public Vector2 speed = new Vector2(5, 5);
	public Vector2 direction = new Vector2(0, -1);
	private Vector2 movement;
	
	void Update() {
		movement = new Vector2(speed.x * direction.x, speed.y * direction.y);
	}
	
	void FixedUpdate() {
		rigidbody2D.velocity = movement;
	}
}
