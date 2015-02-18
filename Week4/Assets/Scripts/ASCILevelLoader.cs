using UnityEngine;
using System.Collections;

public class ASCILevelLoader : MonoBehaviour {

	string row = "X---XXX"; 

	// Use this for initialization
	void Start () {

		char[] rowArray = row.ToCharArray();

		for (int i = 0; i < row.Length; i++){
			char c = rowArray[i];

			if(c == 'X'){
				GameObject brick = Instantiate(Resources.Load("Brick")) as GameObject;
				brick.transform.position = new Vector3(i * brick.transform.localScale.x,15,0);
				//the .x is the X scale of the brick
			}

		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
