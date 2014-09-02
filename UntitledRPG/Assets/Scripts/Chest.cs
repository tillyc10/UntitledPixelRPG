using UnityEngine;
using System.Collections;

public class Chest : MonoBehaviour {

	public Type type;
	private Inventory player;

	public enum Type {
		common,
		uncommon,
		rare,
		relic
	}

	private bool isNear;

	void OnTriggerEnter2D (Collider2D other)
	{
		if ( other.gameObject.tag == "Player" )
		{
			isNear = true;
			player = other.gameObject.GetComponent<Inventory>();
			player.isNearChest = isNear;
			//print ( player.isNearChest );
		}
	}

	void OnTriggerExit2D (Collider2D other)
	{
		if ( other.gameObject.tag == "Player" )
		{
			isNear = false;
			player = other.gameObject.GetComponent<Inventory>();
			player.isNearChest = isNear;
			//print ( player.isNearChest );
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
