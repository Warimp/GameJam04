using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Scroll : MonoBehaviour {

	public float m_moveSpeed = 1.0f;
	public float m_restartpos;
	Vector3 startPOS;

	void Start () {
		startPOS = transform.position;
	}

	// Update is called once per frame
	void Update () {
		transform.Translate((new Vector3(0, -1, 0)) * m_moveSpeed * Time.deltaTime);

		if (transform.position.y < m_restartpos)
			transform.position = startPOS;
	}
}
