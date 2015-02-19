using UnityEngine;
using System.Collections;

public class CubeMove : MonoBehaviour {
	
	public float moveSpeed = 0.5f;
	public static Vector3  playerPos;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		playerPos = transform.position;
		
		MoveButt(KeyCode.W, 0, moveSpeed);
		MoveButt(KeyCode.S, 0, -moveSpeed);
		MoveButt(KeyCode.A, -moveSpeed, 0);
		MoveButt(KeyCode.D, moveSpeed, 0);
		
		//		if (Input.GetKey(KeyCode.W)){
		//			Debug.Log("w is pressed");
		//			transform.position = new Vector3(
		//		         transform.position.x,
		//				transform.position.y + moveSpeed, 
		//				transform.position.z); 
	}
	

	
	//key == W, xMove ==0, yMove == moveSpeed 
	void MoveButt(KeyCode key, float xMove, float yMove){
		if (Input.GetKey (key)) {
			GetComponent<Rigidbody>().velocity = new Vector3(xMove,yMove,0);
			transform.position = new Vector3 (
				transform.position.x + xMove,
				transform.position.y + yMove, 
				transform.position.z);
		}
		
	}
}