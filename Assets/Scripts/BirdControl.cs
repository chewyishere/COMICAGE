using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdControl : MonoBehaviour {


	private bool shouldMove = false;
	public GameObject bird;
	public GameObject hips;
	public Slider rotationSlider;


	Animator anim;
	int danceHash = Animator.StringToHash("dance");



	// Use this for initialization
	void Start () {
		anim = bird.GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {

//		if (shouldMove) {
//
//			transform.Translate (Vector3.forward * Time.deltaTime * (transform.localScale.x * .05f));
//
//		}

	}

	public void Dance(){
		anim.SetTrigger (danceHash);
	}

	public void Rotate(){
		float sliderValue = rotationSlider.value;
		bird.transform.rotation = Quaternion.Euler(0, sliderValue * 360, 0);
	}

	public void LookAt(){

		transform.LookAt (Camera.main.transform.position);
		transform.eulerAngles = new Vector3 (0, transform.eulerAngles.y, 0);
	}

	public void Bigger(){
		transform.localScale += new Vector3 (2, 2, 2);
	}

	public void Smaller(){

		if (transform.localScale.x > 1) {
			transform.localScale -= new Vector3 (2, 2, 2);
		}
	}
}