using UnityEngine;
using System.Collections;

public class LastPlaneDeleteScript : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	

	
	void OnTriggerEnter() {
		Destroy (gameObject);
		
		
	}
	
}