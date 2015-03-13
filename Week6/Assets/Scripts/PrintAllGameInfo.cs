using UnityEngine;
using System.Collections;

public class PrintAllGameInfo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	//polymorphism
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){

			GameObject[] gameObjs = GameObject.FindObjectsOfType<GameObject>();

			//go through each object and put in that variable
			foreach(GameObject obj in gameObjs){
				PrintGameObjectInfo pgoi = obj.GetComponent<PrintGameObjectInfo>();

				if(pgoi != null){
					pgoi.PrintInfo();
				}

			}
		}
	
	
	}
}
