using UnityEngine;
using System.Collections;

public class PrintSphereInfo : PrintGameObjectInfo {
	//PrintGameObjectInfo IS A SUPERCLASS
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//PrintInfo();
		//inheriting from PrintGameObjectInfo
		
	}
	
	protected override string MakeInfoString(){
		SphereCollider sc = GetComponent<SphereCollider>();
		
		string sphereInfo = base.MakeInfoString() + 
			"\nSC Size: " + sc.radius+
				"\nSC Materical: " +sc.material+
				"\nSC Center: " + sc.center;
		//"\nI AM A CUBE";
		
		//return "I AM A CUBE";
		return sphereInfo; 
		
	}
}
