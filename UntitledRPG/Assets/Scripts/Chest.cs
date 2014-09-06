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

	// --------------------------------------------------------------------------------------
	// Player approaches chest
	void OnTriggerEnter2D (Collider2D other)
	{
		if ( other.gameObject.tag == "Player" )
		{
			isNear = true;
			player = other.gameObject.GetComponent<Inventory>();
			//print ( player.isNearChest );
		}
	}

	// --------------------------------------------------------------------------------------
	// Player leaves chest
	void OnTriggerExit2D (Collider2D other)
	{
		if ( other.gameObject.tag == "Player" )
		{
			isNear = false;
			player = other.gameObject.GetComponent<Inventory>();
			//print ( player.isNearChest );
		}
	}

	// --------------------------------------------------------------------------------------
	void OnGUI()
	{
		// Player is near the chest and has not opened it yet
		if ( isNear && !isOpened )
		{
			// Button to open the chest
			if ( GUI.Button ( new Rect ( (Screen.width * 0.5f) - 75, (Screen.height * 0.5f) + 150, 150, 35 ), "Open Chest" ) )
			{
				isOpened = true;
				player.chestOpened = true;
			}
		}

		// The chest has been opened
		if ( isOpened )
		{
			CreateItem();

			// The items have not been collected yet
			if ( !itemsCollected )
			{
				if ( GUI.Button ( new Rect ( (Screen.width * 0.5f) - 75, (Screen.height * 0.5f) + 150, 150, 35 ), itemToSpawn.Name ) )
				{
					if ( itemToSpawn.type == ItemScript.Type.weapon )
					{
						if ( player.weapons.Count > 0 )
						{
							bool haveIt = false;
							int count = 0;

							for ( int x = 0; x < player.weapons.Count; x++ )
							{
								count++;

								if ( player.weapons[x].Name == itemToSpawn.Name )
								{
									if ( player.weapons[x].stackSize < player.weapons[x].maxStackSize )
										player.weapons[x].stackSize++;

									haveIt = true;

									x = player.weapons.Count;
								}
							}

							if ( count == player.weapons.Count && !haveIt )
							{
								player.weapons.Add(itemToSpawn);
							}
						}
						else
							player.weapons.Add(itemToSpawn);
					}
					else
					{
						if ( player.armor.Count > 0 )
						{
							bool haveIt = false;
							int count = 0;

							for ( int x = 0; x < player.armor.Count; x++ )
							{
								count++;

								if ( player.armor[x].Name == itemToSpawn.Name )
								{
									if ( player.armor[x].stackSize < player.armor[x].maxStackSize )
										player.armor[x].stackSize++;

									haveIt = true;

									x = player.armor.Count;
								}
							}

							if ( count == player.armor.Count && !haveIt )
							{
								player.armor.Add(itemToSpawn);
							}
						}
						else
							player.armor.Add(itemToSpawn);
					}

					itemsCollected = true;
				}
			}
		}
	}

	// --------------------------------------------------------------------------------------
	// Spawn random item from appropriate list
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
