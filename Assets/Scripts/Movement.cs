using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	[SerializeField] private GameObject floor;

	float speed;
	Camera facing;

	// Use this for initialization
	void Start () {
		speed = 1f;
		facing = GameObject.Find("Main Camera").GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		OVRInput.Update();
		if (SystemInfo.deviceType == DeviceType.Handheld) {
			if (OVRInput.Get(OVRInput.Touch.PrimaryTouchpad)) {
				/*
				// this is for testing.
				Renderer rend = floor.GetComponent<Renderer>();
				rend.material.SetColor("_Color", Color.red);
				*/

				transform.position = transform.position + facing.transform.forward * Time.deltaTime * speed; 
			}
		} else {
		// technically don't even need this since i'm not putting in mouselook cuz i'm a piece of shit
			transform.position = transform.position + facing.transform.forward * Time.deltaTime * speed * Input.GetAxis("Vertical");
		}

	}
}
