using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public float xSmooth;
	public float ySmooth;

	private Transform player;

	// Use this for initialization
	void Awake () 
	{
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}

	void LateUpdate () 
	{
		TrackPlayer();
	}

	void TrackPlayer()
	{
		float targetX = transform.position.x;
		float targetY = transform.position.y;

		targetX = Mathf.SmoothStep (transform.position.x, player.position.x, xSmooth * Time.deltaTime);
		targetY = Mathf.SmoothStep(transform.position.y, player.position.y, ySmooth * Time.deltaTime);

		transform.position = new Vector3(targetX, targetY, transform.position.z);
	}
}
