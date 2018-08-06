using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

	private bool recording = true;

	public bool Recording
	{
		get
		{
			return recording;
		}
	}

	//Use this for initialization
	void Start ()
	{
		PlayerPrefsManager.UnlockLevel(2);
	}

	// Update is called once per frame
	void Update ()
	{
		if (CrossPlatformInputManager.GetButton("Fire1"))
			recording = false;
		else
			recording = true;
	}

}