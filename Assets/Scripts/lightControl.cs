using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lightControl : MonoBehaviour {
	public Transform target;
	public Slider rotationSlider, colorSlider, ySlider, zSlider, offsetSlider;
	public Transform plane;
	public Color color0 = Color.red;
	public Color color1 = Color.white;
	public Color color2 = Color.blue;
	public Light lt;

	private Quaternion currentRotation = Quaternion.Euler(0, 0, 0);
	private Vector3 currentPos = new Vector3(0,0,0);
	private float l_y = 1f;
	private float l_z = 1f;

	// Use this for initialization
	void Start () {
		lt = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
	}


	public void Update_RotateAround(){
		float v = rotationSlider.value;
		//transform.RotateAround (target.position, Vector3.up, v);
		transform.rotation = Quaternion.AngleAxis(v, Vector3.up);
		transform.position = target.position + Quaternion.AngleAxis(v - 90, Vector3.up) * new Vector3(l_z, l_y, 0);;
		currentPos = transform.localPosition;
		transform.LookAt(target);
	}

	public void Update_LightHeight(){
		float v = ySlider.value;
		transform.localPosition = new Vector3(currentPos.x, v, l_z);
		l_y = v;
		transform.LookAt(target);
	}

	public void Update_LightDistance(){
		float v = zSlider.value;
		transform.localPosition = new Vector3(currentPos.x, l_y, v);
		l_z = v;
		transform.LookAt(target);
	}

		
	public void Update_LightColor(){
		float v = colorSlider.value;
		if(v < 1){ 
			lt.color = Color.Lerp (color0, color1, v);
		} else { 
			lt.color = Color.Lerp (color1, color2, v - 1);
		}

	}



	public void Update_PlaneOffset(){
		float v = offsetSlider.value;
		plane.localPosition = new Vector3(0, v/10, 0);
	}
		
	private static Quaternion Change(float x, float y, float z)
	{
		Quaternion newQuaternion = new Quaternion();
		newQuaternion.Set(x, y, z, 1);
		//Return the new Quaternion
		return newQuaternion;
	}


}

