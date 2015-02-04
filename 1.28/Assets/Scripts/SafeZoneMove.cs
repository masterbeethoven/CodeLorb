using UnityEngine;
using System.Collections;

public class SafeZoneMove : MonoBehaviour {

	public float noiseFreq = 1;
	public float noiseAmp = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float moveX = (Mathf.PerlinNoise(Time.realtimeSinceStartup, 0) - .5f) * noiseAmp;
		float moveY = (Mathf.PerlinNoise(0, Time.realtimeSinceStartup) - .5f) * noiseAmp;

		transform.position = new Vector3 (moveX, moveY, 0); 
	
	}
}
