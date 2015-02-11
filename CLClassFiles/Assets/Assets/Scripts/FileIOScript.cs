using UnityEngine;
using System.Collections;
using System.IO;

public class FileIOScript : MonoBehaviour {

	const string FILE_NAME = "Week3Save.txt";
	// Use this for initialization
	void Start () {

		//Opening up a stream to a file 
		StreamWriter writer = new StreamWriter(FILE_NAME, false);

		//Writing to that file 
		writer.Write("Hello World!");

		//Closing the stream to that file
		writer.Close();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
