using UnityEngine;
using System.Collections;

public class SavePosScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.T)){
			UtilScript.WriteTransToFile("RohanFile2.json", transform);
		}

		if(Input.GetKeyDown(KeyCode.L)){
			 UtilScript.ReadTransformFromFile("RohanFile2.json", transform);
//			transform.position=temp.position;
//			transform.localScale = temp.localScale;
		}

		if(Input.GetKeyDown(KeyCode.Space)){
			UtilScript.WriteVector3ToFile("RohanFile1.json", transform.position);
		}

		if(Input.GetKeyDown(KeyCode.R)){
			UtilScript.ReadVector3FromFile("RohanFile1.json");
			transform.position = UtilScript.ReadVector3FromFile("RohanFile1.json");
		
		}
	
	}
}
