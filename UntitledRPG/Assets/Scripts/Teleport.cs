using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	// Use this for initialization
	public string teleportTarget;
	void Start () {
	
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		Application.LoadLevel (teleportTarget);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
