using UnityEngine;
using System.Collections;

public class Click3DScript : MonoBehaviour {

	public float sphereCastRad = 3f; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 eyePositon = transform.position;

		Vector3 mousePos = Input.mousePosition;

		mousePos.z = Camera.main.nearClipPlane;

		Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(mousePos);

		Debug.Log("mouseWorldPos:" + mouseWorldPos);

		Vector3 dir = mouseWorldPos-eyePositon; 

		dir.Normalize();

		RaycastHit hitter = new RaycastHit();

		if(Physics.SphereCast(eyePositon, sphereCastRad, dir, out hitter)){ //put the values inside hitter to use. pass by reference.
			//a container that creates parameters that you can switch objects in and out of all the time 
			Debug.Log ("HIT SOMETHING!");
			Debug.Log(hitter.collider.gameObject);
		};
	
	}
}
