using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class O_GameManager : MonoBehaviour {

	private float m_Gold;
	public Text m_goldUIText;

	void Awake() {

	}
	
	// Update is called once per frame
	void Update () {
		m_Gold += 1;
		Debug.Log(m_Gold);
		m_goldUIText.text =(int)Mathf.Floor(m_Gold) + " Gold";
	}
}
