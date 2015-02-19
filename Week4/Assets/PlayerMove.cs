using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	
	public float moveSpeed = 0.5f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		MoveButt(KeyCode.W, 0, moveSpeed);
		MoveButt(KeyCode.S, 0, -moveSpeed);
		MoveButt(KeyCode.A, -moveSpeed, 0);
		MoveButt (KeyCode.D, moveSpeed, 0);
		
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
			transform.position = new Vector3 (
				transform.position.x + xMove,
				transform.position.y + yMove, 
				transform.position.z);
		}
		
	}
}