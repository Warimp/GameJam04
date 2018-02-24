using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
private Vector3 = Vector3.zero;
public float m_speed = 1.0f;
public Rigidbody2D m_rb;

	void Awake() {
			m_rb = GetComponent<Rigidbody2D>();
	}


	void Update() {
		pos = gameObject.transform.position;
		pos = gameObject.transform.rotation;
					
		if (Input.GetAxis("Vertical") != 0) {
			pos.y += Input.GetAxis("Vertical") * m_speed;
		}

		if (Input.GetAxis("Horizontal") != 0) {
			pos.x += Input.GetAxis("Horizontal") * m_rotate;
		}
		gameObject.transform.position = pos;
		gameObject.transform.rotation = pos;
	}	
}
