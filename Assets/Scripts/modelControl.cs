using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modelControl : MonoBehaviour {
//	public GameObject selected_character;
	public GameObject[] characters;
	private GameObject selected;
	private Transform target;

	Animator anim;

	private string[] actions = {"belly", "hiphop", "breaking", "salsa", "clap", "talk", "dip", "trip", 
		"sit", "MaleLay", "punch", "ninja", "run", "runningJump","jumpDown","standingJump", 
		"catWalk","laydown","runtoRoll","jumpOver","climb", "capoeria",
		"twerk","tutting","locking","excited","flyingkick","catWalk",
		"nervous", "pointLeft", "pointRight", "argue", "waving","skate","nofaceWalk","nofaceSit","headspinEnd"};


	// Use this for initialization
	void Start () {
		target = Camera.main.transform;

		selected = characters [0];

		for(int i = 0; i < characters.Length; i++)
		{
			characters[i].SetActive(false);
		}

		anim = selected.GetComponent<Animator> ();

	}


	void Update () {
		
	}

	public void OnCharacter(int data) {
		int ndx = data;	

//		for(int i = 0; i < characters.Length; i++)
//		{
//			characters[i].SetActive(false);
//		}

		transform.position = target.position + target.forward * 2f;
		characters [ndx].transform.localPosition = new Vector3 (0, 0, 0);
		transform.LookAt (target);

		characters[ndx].SetActive(true);
		selected = characters [ndx];
		anim = selected.GetComponent<Animator> ();
	
	}
		
	public void OnAction(int data){
		anim.SetTrigger (actions[data]);
	}


	public void OnDestory(){
		selected.SetActive(false);
	}
		
}
