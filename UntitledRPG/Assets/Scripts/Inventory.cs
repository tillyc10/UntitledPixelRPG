using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	public float offset;

	// Size of the inventory window
	public Rect inventoryWindowRect = new Rect(Screen.height * 0.5f, Screen.width * 0.5f, 400, 320);

	// Width and Height of the item buttons
	public float buttonWidth = 40;
	public float buttonHeight = 40;

	// Width and Height of the inventory selector buttons
	public float selectorWidth = 80;
	public float selectorHeight = 80;

	public int inventoryRows = 6;
	public int inventoryCols = 9;

	private int selectorRows = 4;

	private bool displayInventory;
	private const int InventoryWindowID = 0;

	// Lists to hold current inventory based on item type
	public List<Item> items = new List<Item>();
	public List<Item> weapons = new List<Item>();
	public List<Item> armor = new List<Item>();

	// Array holding the inventory selectors
	private string[] Selector = new string[4];

	// Array to hold the equipped items - 0 = helm, 1 = chest, 2 = legs, 3 = weapon
	public Item[] equippedItems = new Item[4];
	private int equippedCount = 4;

	// Bools to determine which "sub" inventory to show (based on selector buttons)
	private bool bShowEquipped;
	private bool bShowItems;
	private bool bShowWeapons;
	private bool bShowArmor;

	// ------------------------------------------------------------------------------------------------------------
	// Use this for initialization
	void Start () {
		Selector[0] = "Equipped";
		Selector[1] = "Items";
		Selector[2] = "Armor";
		Selector[3] = "Weapons";
	}

	// ------------------------------------------------------------------------------------------------------------
	// Add new item to proper location in inventory	
	void OnTriggerEnter2D(Collider2D other)
	{
		Item thisItem;

		if ( other.gameObject.tag == "Item" )
		{
			thisItem = other.gameObject.GetComponent<Item>();

			if ( thisItem.type.ToString() == "item"  )
			{
				items.Add ( thisItem );
			}
			else if ( thisItem.type.ToString() == "weapon" )
			{
				weapons.Add ( thisItem );
			}
			else if ( thisItem.type.ToString() == "helm" || thisItem.type.ToString() == "chest" ||
			         thisItem.type.ToString() == "arms" || thisItem.type.ToString() == "legs")
			{
				armor.Add ( thisItem );
				//print ( armor[0] );
			}

			Destroy( other.gameObject );
		}
	}

	// ------------------------------------------------------------------------------------------------------------
	// Drawing to the HUD
	void OnGUI()
	{
		if(displayInventory)
		{
			inventoryWindowRect = GUI.Window(InventoryWindowID, inventoryWindowRect, InventoryWindow, "Inventory");
		}
	}

	// ------------------------------------------------------------------------------------------------------------
	// The inventory window
	public void InventoryWindow(int ID)
	{
		int cnt = 0;

		// Drawing the selection buttons to view different types of items in the inventory
		for ( int topRow = 0; topRow < selectorRows; topRow++ )
		{
			// Handle which selector button is pressed
			if ( GUI.Button ( new Rect ( 35 + ( topRow * selectorWidth), 20, selectorWidth, selectorHeight), "" + Selector[topRow] ) )
			{
				if ( Selector[topRow] == "Equipped" )
				{
					// Show the equipped items
					bShowEquipped = true;

					// Hide others
					bShowArmor = false;
					bShowItems = false;
					bShowWeapons = false;
				}
				else if ( Selector[topRow] == "Items" )
				{
					// Show the general items
					bShowItems = true;

					// Hide others
					bShowArmor = false;
					bShowEquipped = false;
					bShowWeapons = false;
				}
				else if ( Selector[topRow] == "Armor" )
				{
					// Show the armor items
					bShowArmor = true;

					// Hide others
					bShowItems = false;
					bShowEquipped = false;
					bShowWeapons = false;
				}
				else if ( Selector[topRow] == "Weapons" )
				{
					// Show the weapon items
					bShowWeapons = true;
					
					// Hide others
					bShowItems = false;
					bShowEquipped = false;
					bShowArmor = false;
				}
			}
		}

		// if we want to show the currently equipped items
		if ( bShowEquipped )
		{
			for ( int x = 0; x < equippedItems.Length; x++ )
			{
				// if we have items to show
				if ( x < equippedCount )
				{
					GUI.Button ( new Rect (20 + (x * buttonWidth), 65, buttonWidth, buttonHeight ), x.ToString());

					if ( x == 3 )
					{

					}
				}
				// we dont have items to show
				else
					GUI.Label ( new Rect (20 + (x * buttonWidth), 65, buttonWidth, buttonHeight ), "none", "box");
			}
		}

		// if we want to show the general items that arent currently equipped
		if ( bShowItems )
		{
			for ( int y = 0; y < inventoryRows; y++ )
			{
				for ( int x = 0; x < inventoryCols; x++ )
				{
					// if we have items to show
					if ( cnt < items.Count )
					{
						GUI.Button ( new Rect(20 + (x * buttonWidth), 65 + (y * buttonHeight), buttonWidth, buttonHeight ), ( x + y * inventoryCols).ToString());
					}
					// we dont have items to show
					else
						GUI.Label ( new Rect(20 + (x * buttonWidth), 65 + (y * buttonHeight), buttonWidth, buttonHeight ), "none", "box");
					
					cnt++;
				}
			}
		}

		// if we want to show the armor that is not equipped
		if ( bShowArmor )
		{
			for ( int y = 0; y < inventoryRows; y++ )
			{
				for ( int x = 0; x < inventoryCols; x++ )
				{
					// if we have items to show
					if ( cnt < armor.Count )
					{
						if ( GUI.Button ( new Rect(20 + (x * buttonWidth), 65 + (y * buttonHeight), buttonWidth, buttonHeight ), ( x + y * inventoryCols).ToString()) )
						{
							EquipArmor( x + y * inventoryCols );
							//print ( x + y * inventoryCols );
						}
					}
					// we dont have items to show
					else
						GUI.Label ( new Rect(20 + (x * buttonWidth), 65 + (y * buttonHeight), buttonWidth, buttonHeight ), "none", "box");
					
					cnt++;
				}
			}
		}

		// if we want to show the weapons that are not equipped
		if ( bShowWeapons )
		{
			for ( int y = 0; y < inventoryRows; y++ )
			{
				for ( int x = 0; x < inventoryCols; x++ )
				{
					// if we have items to show
					if ( cnt < weapons.Count )
					{
						if ( GUI.Button ( new Rect(20 + (x * buttonWidth), 65 + (y * buttonHeight), buttonWidth, buttonHeight ), ( x + y * inventoryCols).ToString()) )
						{
							EquipWeapon ( x + y * inventoryCols );
						}
					}
					// we dont have items to show
					else
						GUI.Label ( new Rect(20 + (x * buttonWidth), 65 + (y * buttonHeight), buttonWidth, buttonHeight ), "none", "box");
					
					cnt++;
				}
			}
		}
	}

	// ------------------------------------------------------------------------------------------------------------
	// Move armor from inventory to equipped items
	public void EquipArmor(int placeInList)
	{
		ModifiedStats stats = GetComponent<ModifiedStats>();

		int dexBuff = 0;
		int strBuff = 0;
		int intBuff = 0;
		int armorBuff = 0;

		// place the armor in the appropriate slot, here we should also
		// move the equipped armor to the armor inventory
		if ( armor[placeInList].type == Item.Type.helm )
		{
			equippedItems[0] = armor[placeInList];
			armor.Remove ( armor[placeInList] );
		}
		else if ( armor[placeInList].type == Item.Type.chest )
		{
			equippedItems[1] = armor[placeInList];
			armor.Remove ( armor[placeInList] );
		}
		else if ( armor[placeInList].type == Item.Type.legs )
		{
			equippedItems[2] = armor[placeInList];
			armor.Remove ( armor[placeInList] );
		}

		//equippedCount += 1;

		for ( int x = 0; x < equippedItems.Length; x++ )
		{
			if ( x < equippedCount )
			{
				dexBuff += equippedItems[x].dexBoost;
				strBuff += equippedItems[x].strBoost;
				intBuff += equippedItems[x].intBoost;
				armorBuff += equippedItems[x].armorClass;
			}
		}

		stats._buffDEX = dexBuff;
		stats._buffSTR = strBuff;
		stats._buffINT = intBuff;
		stats._armorClass = armorBuff;

		print ( "Dex Buff is " + stats._buffDEX );
		//print ( "Armor Buff is " + stats._armorClass );
	}

	// ------------------------------------------------------------------------------------------------------------
	// Move weapon from inventory to equipped items
	public void EquipWeapon(int placeInList)
	{
		ModifiedStats stats = GetComponent<ModifiedStats>();

		if ( weapons[placeInList].type == Item.Type.weapon )
		{
			equippedItems[3] = weapons[placeInList];
			weapons.Remove( weapons[placeInList] );
			stats._baseDamage = equippedItems[3].damage; 
		}
	}

	// ------------------------------------------------------------------------------------------------------------
	// To display or not too display...
	public void ToggleInventoryWindow()
	{
		if ( Input.GetKeyUp(KeyCode.I) )
		{
			displayInventory = !displayInventory;
			if ( !bShowEquipped && !bShowArmor && !bShowWeapons && !bShowItems )
			{
				bShowEquipped = true;
			}
		}
	}

	// ------------------------------------------------------------------------------------------------------------
	// Update is called once per frame
	void Update () {
	
		ToggleInventoryWindow();

	}
}
