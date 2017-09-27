using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour {

	public float speed;

	void Start () {
		//TODO Set scale and position before initialisation
		transform.localScale = new Vector3(Random.Range(1, 3), Random.Range(1, 3), Random.Range(1, 3));
	}
	
	void Update () {
		if(transform.localPosition.y < -1) {
			Destroy(this.gameObject);
		}
		transform.Translate(speed * Vector3.down * Time.deltaTime);
	}
}
