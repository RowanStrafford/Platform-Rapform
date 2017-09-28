using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour {

	public float speed;
	public bool floats = false;

	void Start () {
		//TODO Set scale and position before initialisation
		if (floats) {
			return;
		}
		transform.localScale = new Vector3(Random.Range(1, 3), Random.Range(1, 3), 1);
	}
	
	void Update () {
		if (floats) {
			return;
		}
		
		if(transform.localPosition.y < -1) {
			Destroy(this.gameObject);
		}
		transform.Translate(speed * Vector3.down * Time.deltaTime);
	}
}
