using UnityEngine;
using System.Collections;
using System.IO;

public class FileIOScript : MonoBehaviour {

	const string FILE_NAME = "Week3Save.txt";
	// Use this for initialization
	void Start () {

		//Opening up a stream to a file to wrtie to
		StreamWriter writer = new StreamWriter(FILE_NAME, false);

		//Writing to that file 
		writer.Write("Hello World!");

		//Closing the stream to that file
		writer.Close();

		//opwn up a stream to file to read from
		StreamReader reader = new StreamReader (FILE_NAME);

		int content = reader.Read();

		Debug.Log (content);

		content=reader.Read();

		Debug.Log (content);

		reader.Close ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
