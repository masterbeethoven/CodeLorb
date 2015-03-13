using UnityEngine;
using System.Collections;

public class PrintGameObjectInfo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//PrintInfo();
	
	}

	public void PrintInfo(){
		Debug.Log (MakeInfoString());

	}

	protected virtual string MakeInfoString(){
		string infoString;

		infoString = "Name: " + gameObject.name +
			"Position: " + transform.position.ToString() + 
				"\nRotation: " + transform.rotation +
				"\nScale: " + transform.localScale;


	

		return infoString;

	}
}

//have to click on the console outputs to get that info
