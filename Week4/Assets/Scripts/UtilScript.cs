using UnityEngine;
using System.Collections;
using SimpleJSON;
using System.IO;


public class UtilScript{

	const string JSON_X = "x"; 
	const string JSON_Y = "y"; 
	const string JSON_Z = "z";
	const string JSON_POS = "position"; 
	const string JSON_SCALE = "scale";

	
	public static Vector3 Vector3Mod(Vector3 initVec, float xMod, float yMod){
		return Vector3Mod (initVec, xMod, yMod, 0);
	}
	
	public static Vector3 Vector3Mod(Vector3 initVec, float xMod, float yMod, float zMod){
		Vector3 returnVec = new Vector3 (initVec.x + xMod,
		                                 initVec.y + yMod,
		                                 initVec.z + zMod);
		
		return returnVec;
	} 

	public static void WriteTransToFile(string fileName, Transform transform){
		//string contents; 

		JSONClass jTrans = new JSONClass(); 

		jTrans[JSON_POS] = JSON.Parse(Vector3ToJson(transform.position));
		jTrans[JSON_SCALE]=JSON.Parse(Vector3ToJson(transform.localScale));

		SaveStringToFile(fileName, jTrans.ToString());

	
	}

	public static void ReadTransformFromFile(string fileName, Transform position){
		//return null;
		//fill out this stub
		string contents = ReadStringFromFile(fileName);
		JSONNode node = JSON.Parse (contents);
		string x =node[JSON_POS].ToString();
		string y =node[JSON_SCALE].ToString();
		Vector3 vec = JsonToVector3 (x);
		Vector3 scale = JsonToVector3 (y);
//		Transform position = Component.Instantiate (;
		position.localScale = scale;
		position.position = vec; 
//		return position;

		
	}

	public static Vector3 ReadVector3FromFile(string fileName){
		string contents = ReadStringFromFile(fileName);
		Vector3 vec = JsonToVector3 (contents); 
		return vec; 

	}

	public static void WriteVector3ToFile(string fileName, Vector3 vec){
		string contents = Vector3ToJson(vec);
		SaveStringToFile (fileName, contents);
	}

	public static Vector3 JsonToVector3(string json){
		Vector3 result; 

		JSONNode node = JSON.Parse (json); 
		//look through text, cut it up, and then read inside the field 
		float x =node[JSON_X].AsFloat;
		float y =node[JSON_Y].AsFloat;
		float z =node[JSON_Z].AsFloat;

		return new Vector3(x,y,z);

	}

	public static string Vector3ToJson(Vector3 vec){
		JSONClass node = new JSONClass(); 

		node[JSON_X].AsFloat= vec.x;
		node[JSON_Y].AsFloat= vec.y;
		node[JSON_Z].AsFloat= vec.z;

		return node.ToString();

	}

	public static string ReadStringFromFile(string fileName){
		//returns contents of the file 
	StreamReader reader = new StreamReader (fileName, false);
		string retFile = reader.ReadToEnd(); 
		Debug.Log ("read file " +retFile); 
		reader.Close();
		return retFile;

	}

	public static void SaveStringToFile(string fileName, string contents){
		StreamWriter writer = new StreamWriter (fileName, false);
		writer.Write(contents); 
		//Debug.Log("written file " + retFile);
		writer.Close ();
		
	}
}
