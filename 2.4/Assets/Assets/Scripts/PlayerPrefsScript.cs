using UnityEngine;
using System.Collections;

public class PlayerPrefsScript : MonoBehaviour {

	const string SOUND_VOL_KEY = "soundVolKey";

	private int soundVolume;

	public int SoundVolume{
		get{
			soundVolume=PlayerPrefs.GetInt(SOUND_VOL_KEY);
			return soundVolume;}
		set{soundVolume = value;
			//setting soundVolume to a value that it's getting set elsewhere (in this case, the Start)
			PlayerPrefs.SetInt(SOUND_VOL_KEY, soundVolume);
		}
	}

	// Use this for initialization
	void Start () {
		//SoundVolume=10;
		//if comment out, there will be nothing saved, because it's not getting anything 
		SoundVolume= PlayerPrefs.GetInt(SOUND_VOL_KEY);
		//SoundVolume= PlayerPrefs.GetInt(SOUND_VOL_KEY,20);
		//the 20 is the 'default' value set if no one sets their own volume 
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Current Volume: "+ SoundVolume);
	}
}
