using UnityEngine;
using System.Collections;

public class GameManagerScript : MonoBehaviour {

	private int highScore; //property

	public int HighScore{ //value 
		get{ 
			Debug.Log ("Got High Score");
			return highScore;
		}
		set{ 
			Debug.Log("Set High Score");
			highScore = value;
		}
	}

	public static int score =7;

	public const float Gravity = 9.8f;

	public const float MoonGravity = 1.622f;

	private int userId = 9;

	//singleton 
	private static GameManagerScript instance;

	public static GameManagerScript GetInstance(){
		return instance; 

	}

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(gameObject);

		instance=this; //this means the thing we are in right now. we're in this particular instance of gamemanager
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0)){
			Application.LoadLevel("Week2-2");
		}
	
	}
}
