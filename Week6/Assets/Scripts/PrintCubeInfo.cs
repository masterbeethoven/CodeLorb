using UnityEngine;
using System.Collections;

public class PrintCubeInfo : PrintGameObjectInfo {
	//PrintGameObjectInfo IS A SUPERCLASS

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		PrintInfo();
		//inheriting from PrintGameObjectInfo
	
	}

	protected override string MakeInfoString(){
		BoxCollider bc = GetComponent<BoxCollider>();

		string cubeInfo = base.MakeInfoString() + 
			"\nBC Size: " + bc.size+
			"\nBC Materical: " +bc.material+
				"\nBC Center: " + bc.center;
			//"\nI AM A CUBE";

		//return "I AM A CUBE";
		return cubeInfo; 

	}
}
