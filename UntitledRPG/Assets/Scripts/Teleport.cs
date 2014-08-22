using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	// Use this for initialization
	public bool dungeon = false;
	public bool village = true;
	void Start () {
	
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		print ( "Collided with" );
		if (village) 
		{
			Application.LoadLevel ("DungeonTest");
			village = false;
			dungeon = true;
		}
		else if (dungeon)
		{
			Application.LoadLevel ("Test");
			village = true;
			dungeon = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
