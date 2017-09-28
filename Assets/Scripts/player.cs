using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	public float horiAcc;
	private float horiSpeed = 0;
	public float vertAcc;
	private float vertSpeed = 0;
	private bool canJump;

	private int jumpTimer = 0;

	void Start () {
		
	}
	
	void Update () {
		handleMovement();
		handleCollision();
	}

	void OnTriggerStay(Collider other) {
		canJump = true;
		jumpTimer = 5;
		vertSpeed = 0;
	}

	private void handleCollision() {
	//	if(collider.)
		jumpTimer--;
		if (jumpTimer <= 0) {
			canJump = false;
		}
	}

	private void handleMovement() {
		transform.Translate(horiSpeed, 0, 0);

		if (Input.GetKey("a")) {
			horiSpeed -= 0.005f;
		}
		if (Input.GetKey("d")) {
			horiSpeed += 0.005f;
		}

		horiSpeed = horiSpeed * 0.95f;

		if (transform.localPosition.x < -GameManager.WIDTH / 2) {
			transform.SetPositionAndRotation(new Vector3(GameManager.WIDTH / 2, transform.position.y, transform.position.z), Quaternion.identity);
		}
		if (transform.localPosition.x > +GameManager.WIDTH / 2) {
			transform.SetPositionAndRotation(new Vector3(-GameManager.WIDTH / 2, transform.position.y, transform.position.z), Quaternion.identity);
		}


		if (Input.GetKey("w")) {
			jump();
		}

		transform.Translate(0, vertSpeed, 0);

		if (transform.localPosition.y < 0) {
			vertSpeed = 0;
			transform.SetPositionAndRotation(new Vector3(transform.position.x, 0, transform.position.z), Quaternion.identity);
		} else {
			vertSpeed -= 0.002f;
		}
	}

	void jump() {
		if (canJump) {
			vertSpeed = vertAcc;
			canJump = false;
		}
	}
}
