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

	private ItemScript itemToSpawn;

	private bool isNear;
	private bool isOpened;
	private bool itemSpawned;
	private bool itemsCollected;

	void OnTriggerEnter2D (Collider2D other)
	{
		if ( other.gameObject.tag == "Player" )
		{
			isNear = true;
			player = other.gameObject.GetComponent<Inventory>();
			//print ( player.isNearChest );
		}
	}

	void OnTriggerExit2D (Collider2D other)
	{
		if ( other.gameObject.tag == "Player" )
		{
			isNear = false;
			player = other.gameObject.GetComponent<Inventory>();
			//print ( player.isNearChest );
		}
	}

	void OnGUI()
	{
		if ( isNear && !isOpened )
		{
			if ( GUI.Button ( new Rect ( (Screen.width * 0.5f) - 75, (Screen.height * 0.5f) + 150, 150, 35 ), "Open Chest" ) )
			{
				isOpened = true;
				player.chestOpened = true;
			}
		}

		if ( isOpened )
		{
			CreateItem();

			if ( !itemsCollected )
			{
				if ( GUI.Button ( new Rect ( (Screen.width * 0.5f) - 75, (Screen.height * 0.5f) + 150, 150, 35 ), itemToSpawn.Name ) )
				{
					if ( itemToSpawn.type == ItemScript.Type.weapon )
						player.weapons.Add(itemToSpawn);
					else
						player.armor.Add(itemToSpawn);

					itemsCollected = true;
				}
			}
		}
	}

	void CreateItem()
	{
		if ( !itemSpawned )
		{
			int random = Random.Range ( 0, 5 );

			if ( type == Type.common )
			{
				if ( random <= 3 )
					itemToSpawn = player.completeItemList.RandomItem( player.completeItemList.commonArmor );
				else
					itemToSpawn = player.completeItemList.RandomItem( player.completeItemList.commonWeapons );

				itemSpawned = true;
			}
			else if ( type == Type.uncommon )
			{
				if ( random <= 3 )
					itemToSpawn = player.completeItemList.RandomItem( player.completeItemList.uncommonArmor );
				else
					itemToSpawn = player.completeItemList.RandomItem( player.completeItemList.uncommonWeapons );

				itemSpawned = true;
			}
			else if ( type == Type.rare )
			{
				if ( random <= 3 )
					itemToSpawn = player.completeItemList.RandomItem( player.completeItemList.rareArmor );
				else
					itemToSpawn = player.completeItemList.RandomItem( player.completeItemList.rareWeapons );

				itemSpawned = true;
			}
			else if ( type == Type.relic )
			{
				if ( random <= 3 )
					itemToSpawn = player.completeItemList.RandomItem( player.completeItemList.relicArmor );
				else
					itemToSpawn = player.completeItemList.RandomItem( player.completeItemList.relicWeapons );

				itemSpawned = true;
			}

			print ( itemToSpawn.Name );
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
