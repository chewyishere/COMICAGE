using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panelControl_c : MonoBehaviour {

	Animator anim;
	bool c_Show;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		c_Show = false;
		anim.SetBool ("show_character", false);
	}
	
	// Update is called once per frame
	void Update () {
		if (c_Show == true) {
			anim.SetBool ("show_character", true);

		} else {
			anim.SetBool ("show_character", false);
		}
	}

	public void toggleMenu(){
		if (c_Show == false) { 
			c_Show = true;
		} else {
			c_Show = false;
		}

	}
		
}
