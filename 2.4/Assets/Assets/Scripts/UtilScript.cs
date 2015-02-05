using UnityEngine;
using System.Collections;

public class UtilScript  {
	public static Vector3 Vector3Mod(Vector3 initVec, float xMod, float yMod){
		return Vector3Mod (initVec, xMod, yMod, 0);
	}

	//takes vector3 modding, the x, y, z --designed this 
	public static Vector3 Vector3Mod(Vector3 initVec, float xMod, float yMod, float zMod){

		Vector3 returnVec = new Vector3(initVec.x + xMod, initVec.y + yMod, initVec.z + zMod);

		return returnVec;

	}
}
