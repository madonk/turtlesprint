using UnityEngine;
using System.Collections;

public class TurtleMoveScript : MonoBehaviour {

	public float maxSpeed = 5f;		
	
	void Start() {
		
	}
	
	void FixedUpdate () {
		// Cache the horizontal input.
		float move = Input.GetAxis("Horizontal");
		
		rigidbody2D.velocity = new Vector2 (move * maxSpeed, rigidbody2D.velocity.y);
	}
}
