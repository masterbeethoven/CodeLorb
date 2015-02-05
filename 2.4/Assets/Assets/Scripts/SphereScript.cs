using UnityEngine;
using System.Collections;

public class SphereScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = UtilScript.Vector3Mod(transform.position,-0.1f,0,0);

		GameManagerScript manager = GameManagerScript.GetInstance();

		Debug.Log ("High Score: " + manager.HighScore);
	
		Debug.Log ("Score: " + GameManagerScript.score);

		Debug.Log ("MoonGravity: " + GameManagerScript.MoonGravity);
		//calling moongravity property of the class gamemanger 
		//paraenthesis is calling function, doing something  
		//. is just accessing, getting and setting value
	}
}
