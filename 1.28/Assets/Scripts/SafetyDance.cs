using UnityEngine;
using System.Collections;

public class SafetyDance : MonoBehaviour {

	GameObject target;

	// Use this for initialization
	void Start () {
		target = GameObject.Find("SafeZone");
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(transform.position, target.transform.position) > 3){
			Destroy(gameObject);
		}
	}
}
