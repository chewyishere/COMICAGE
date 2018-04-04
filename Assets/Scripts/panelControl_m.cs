using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panelControl_m : MonoBehaviour {

	Animator anim;
	bool m_Show;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		m_Show = false;
		anim.SetBool ("panelshow_m", false);
	}
	
	// Update is called once per frame
	void Update () {
		if (m_Show == true) {
			anim.SetBool ("panelshow_m", true);
		} else {
			anim.SetBool ("panelshow_m", false);
		}

	}

	public void toggleMenu(){
		if (m_Show == false) {
			m_Show = true;
		} else {
			m_Show = false;
		}

	}
		
}
