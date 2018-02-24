using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

public float m_speed = 1.0f;
public Rigidbody2D m_rb;
public Vector3 = Vector3.zero;


	void Awake() {
			m_rb = GetComponent<Rigidbody2D>();
			
	}

	void Update() {

		transform.position =  gameObject.transform.position;
		
					
		if (Input.GetAxis("Vertical") != 0) {
			pos.y += Input.GetAxis("Vertical") * m_speed;
		}

		if (Input.GetAxis("Horizontal") != 0) {
			pos.x += Input.GetAxis("Horizontal") * m_speed;
		}

		
		 
		
	}	
}
