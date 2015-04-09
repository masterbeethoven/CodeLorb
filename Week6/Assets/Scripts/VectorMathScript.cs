using UnityEngine;
using System.Collections;

public class VectorMathScript : MonoBehaviour {

	public Vector3 start; 
	public Vector3 dir1; 
	public Vector3 dir2; 
	public Vector3 normalized1; 
	public Vector3 normalized2;

	public GameObject cube;
	public GameObject sphere;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//dir1.Normalize(); // turns it into normalize
		Vector2 normalized1 = dir1.normalized;//returns the value 
		Vector2 normalized2 = dir2.normalized;
		Debug.DrawRay(start, dir1, Color.magenta);
		Debug.DrawRay(start, normalized1, Color.black);
		Debug.DrawRay(start, dir2, Color.cyan);
		Debug.DrawRay(start, normalized2, Color.black);

		Vector3 cross = Vector3.Cross(normalized1, normalized2);
		cross.Normalize();
		Debug.Log ("cross mag: " + cross.magnitude);

		cube.transform.RotateAround(cube.transform.position, cross, Time.deltaTime *10); //rotates whatever is perpendicular to the two angles
		Debug.DrawRay(start, Vector3.Cross (normalized1, normalized2), Color.blue);

		Vector3 rayToSphere = sphere.transform.position - cube.transform.position;
		Debug.Log (Vector3.Dot(dir1, rayToSphere));
	
	}
}
