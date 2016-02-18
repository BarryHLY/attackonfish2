﻿using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	public float speed = 5f;
	
	void Update () {
		this.transform.Translate(-speed * Time.deltaTime, 0, 0);

        if(this.transform.position.x < -11)
        {
            Destroy(gameObject);
        }
	}
	
	void OnTriggerEnter2D (Collider2D coll) {
		if (coll.gameObject.tag == "player") {
			Destroy(gameObject);
			Player.itemBoost = true;
		}
	}
}