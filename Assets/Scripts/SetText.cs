using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetText : MonoBehaviour {

	string deviceType;

	// Use this for initialization
	void Start () {
		if (SystemInfo.deviceType == DeviceType.Desktop) {
			deviceType = "Desktop";
		}
		else if (SystemInfo.deviceType == DeviceType.Handheld) {
			deviceType = "Handheld";
		}
		else if (SystemInfo.deviceType == DeviceType.Console) {
			deviceType = "Console";
		} else {
			deviceType = "Unknown";
		}
		gameObject.GetComponent<TextMesh>().text = deviceType;
	}
	
	// Update is called once per frame
	void Update () {
	}
}
