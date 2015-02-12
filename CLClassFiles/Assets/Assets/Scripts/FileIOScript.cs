using UnityEngine;
using System.Collections;
using System.IO;

public class FileIOScript : MonoBehaviour {

	const string FILE_NAME = "Week3Save.txt";
	const char DELIMITER = '|';

	string name = "Matt"; 
	int score = 1000; 
	// Use this for initialization
	void Start () {

		//Vector3 vec = new Vector3(100,200,300);
		//vectors are possible 
		//Opening up a stream to a file to wrtie to
		StreamWriter writer = new StreamWriter(FILE_NAME, false);

		//Writing to that file 
		writer.Write(name + DELIMITER + score);
		//2 string function, pass obj or primative into a string 

		//Closing the stream to that file
		writer.Close();

		//opwn up a stream to file to read from
		StreamReader reader = new StreamReader (FILE_NAME);

		string content = reader.ReadLine();

		char[] delimiterChars ={'|'};

		string[] scoreSplit = content.Split(delimiterChars);

		Debug.Log ("name: " + scoreSplit[0]);
		Debug.Log ("score: " + scoreSplit[1]);

		int saveScore = int.Parse(scoreSplit[1]);

		reader.Close ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
