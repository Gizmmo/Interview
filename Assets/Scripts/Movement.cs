using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed = 5;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveX = Input.GetAxis ("Horizontal");
		float moveY = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2(speed * moveX, speed * moveY);
		rigidbody2D.MovePosition(rigidbody2D.position + movement * Time.deltaTime);
	}
}
