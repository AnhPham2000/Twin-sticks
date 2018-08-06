using UnityEngine;
using System.Collections;

public class SelfieStick : MonoBehaviour {

	private GameObject player;
	private float panSpeed = 10f;
	private Vector3 armRotation;

	//Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		armRotation = transform.rotation.eulerAngles;
	}

	// Update is called once per frame
	void Update () {
		armRotation.y += Input.GetAxis("RHorizonal") * panSpeed;
		armRotation.x += Input.GetAxis("RVertical") * panSpeed;
		transform.rotation = Quaternion.Euler(armRotation);
		transform.position = player.transform.position;
	}
}