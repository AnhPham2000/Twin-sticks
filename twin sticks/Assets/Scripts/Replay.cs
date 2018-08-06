using UnityEngine;
using System.Collections;

public class Replay : MonoBehaviour {

	private const int bufferFrames = 1000;
	private MyKeyFrame[] keyFrames = new MyKeyFrame[bufferFrames];
	private Rigidbody rigidbody;
	private GameManager gamemanager;

	//Use this for initialization
	void Start ()
	{
		gamemanager = GameObject.FindObjectOfType<GameManager>();
		rigidbody = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update ()
    {
		if (gamemanager.Recording)
    		 Record();
		else
			PlayBack();
    }

	void PlayBack()
	{
		rigidbody.isKinematic = true;
		int frame = Time.frameCount % bufferFrames;
		transform.position = keyFrames[frame].Postion;
		transform.rotation = keyFrames[frame].rotation;
	}

   void Record()
    {
		rigidbody.isKinematic = false;
        int frame = Time.frameCount % bufferFrames;
        float time = Time.time;
        keyFrames[frame] = new MyKeyFrame(time, transform.position, transform.rotation);
    }
}


/// <summary>
/// A structure for storing time, rotation and position
/// </summary>
public struct MyKeyFrame {

	public float frameTime;
	public Vector3 Postion;
	public Quaternion rotation;

	public MyKeyFrame (float aTime, Vector3 aPostion, Quaternion aRotation)
	{
		frameTime = aTime;
		Postion = aPostion;
		rotation = aRotation;
	}

}