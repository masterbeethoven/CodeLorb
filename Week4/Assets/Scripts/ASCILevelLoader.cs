using UnityEngine;
using System.Collections;
using System.IO;

public class ASCILevelLoader : MonoBehaviour {

	public string fileName;
	//public string [] level;

	public float offsetX; 
	public float offsetY; 

	//string row = "X---XXX"; 


	// Use this for initialization
	void Start () {


		StreamReader reader = new StreamReader (fileName); 

		string contentOfFile = reader.ReadLine ();
		reader.Close ();
		char[] newLineChar = {'\n'};
		string[] level = contentOfFile.Split (newLineChar);


		for(int y = 0; y< level.Length; y++){
			MakeRow (level[y], -y);
		}
		//row passed, and then y is 0
	/*	char[] rowArray = row.ToCharArray();

		for (int i = 0; i < row.Length; i++){
			char c = rowArray[i];

			if(c == 'X'){
				GameObject brick = Instantiate(Resources.Load("Brick")) as GameObject;
				brick.transform.position = new Vector3(i * brick.transform.localScale.x,15,0);
				//the .x is the X scale of the brick
			}

		}*/
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void MakeRow(string rowStr, int y) {
		char[] rowArray = rowStr.ToCharArray();
		
		for (int i = 0; i < rowStr.Length; i++){
			char c = rowArray[i];
			
			if(c == 'X'){
				GameObject brick = Instantiate(Resources.Load("Brick")) as GameObject;
				brick.transform.position = new Vector3(
					i * brick.transform.localScale.x + offsetX,
				//the .x is the X scale of the brick
					y * brick.transform.localScale.y + offsetY,
				0);
			} else if (c =='S'){
				GameObject sphere = Instantiate(Resources.Load("Sphere")) as GameObject;
				sphere.transform.position = new Vector3(
					i * sphere.transform.localScale.x + offsetX,
					y * sphere.transform.localScale.y + offsetY,
					0);
			}
			
		}


	}
}
