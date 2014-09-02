using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	public float offset;

	// Size of the inventory window
	private Rect inventoryWindowRect = new Rect((Screen.width * 0.25f) - 200, (Screen.height * 0.5f) - 160, 400, 320);
	private Rect descriptionWindowRect = new Rect((Screen.width * 0.75f) - 200, (Screen.height * 0.5f) - 160, 400, 320);

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

	private bool displayDescription;
	private const int DescriptionWIndowID = 1;

	// Lists to hold current inventory based on item type
	public List<ItemScript> items = new List<ItemScript>();
	public List<ItemScript> weapons = new List<ItemScript>();
	public List<ItemScript> armor = new List<ItemScript>();

	// Array holding the inventory selectors
	private string[] Selector = new string[4];

	// Array to hold the equipped items - 0 = helm, 1 = chest, 2 = legs, 3 = weapon
	public ItemScript[] equippedItems = new ItemScript[4];
	private int equippedCount;
	private bool initialEquip;
	private float timeToLoad;
	private float timeToEquip = 1;

	// Bools to determine which "sub" inventory to show (based on selector buttons)
	private bool bShowEquipped;
	private bool bShowItems;
	private bool bShowWeapons;
	private bool bShowArmor;

	public bool chestOpened;

	private ItemScript clickedItem;
	private int placeInList;

	public Item completeItemList;

	// ------------------------------------------------------------------------------------------------------------
	// Use this for initialization
	void Start () {
		Selector[0] = "Equipped";
		Selector[1] = "Items";
		Selector[2] = "Armor";
		Selector[3] = "Weapons";

		completeItemList = GetComponent<Item>();
	}

	void WaitToEquip()
	{
		if ( timeToLoad >= timeToEquip )
		{
			equippedItems[1] = completeItemList.commonArmor[0];
			equippedItems[2] = completeItemList.commonArmor[1];
			equippedItems[3] = completeItemList.commonWeapons[0];

			initialEquip = true;
			timeToLoad = 0f;
		}
		else
			timeToLoad += Time.deltaTime;
	}

	// ------------------------------------------------------------------------------------------------------------
	// Drawing to the HUD
	void OnGUI()
	{
		if(displayInventory)
		{
			inventoryWindowRect = GUI.Window(InventoryWindowID, inventoryWindowRect, InventoryWindow, "Inventory");
			descriptionWindowRect = GUI.Window (DescriptionWIndowID, descriptionWindowRect, DescriptionWindow, "Item");
		}
	}

	public void DescriptionWindow(int ID)
	{
		if ( clickedItem != null )
		{
			GUI.Label ( new Rect ( 10, 15, 200, 50 ), "Name: " + clickedItem.Name );
			GUI.Label ( new Rect ( 10, 30, 200, 50 ), "Description: " + clickedItem.description );
			GUI.Label ( new Rect ( 10, 75, 200, 50 ), "Dex Boost: " + clickedItem.dexBoost );
			GUI.Label ( new Rect ( 10, 90, 200, 50 ), "Str Boost: " + clickedItem.strBoost );
			GUI.Label ( new Rect ( 10, 105, 200, 50 ), "Int Boost: " + clickedItem.intBoost );
			GUI.Label ( new Rect ( 10, 120, 200, 50 ), "Armor Class: " + clickedItem.armorClass );
			GUI.Label ( new Rect ( 10, 135, 200, 50 ), "Damage: " + clickedItem.damage );
			GUI.Label ( new Rect ( 10, 150, 200, 50 ), "Type: " + clickedItem.type );
			GUI.Label ( new Rect ( 10, 165, 200, 50 ), "Rarity: " + clickedItem.rarity );

			if ( !bShowEquipped )
			{
				if ( GUI.Button ( new Rect ( 65, 200, 80, 40 ), "Equip" ) )
				{
					if ( clickedItem.type == ItemScript.Type.weapon )
						EquipWeapon( placeInList );
					else
						EquipArmor( placeInList );

					//print ( "equipped" );
				}
				GUI.Label ( new Rect ( 155, 200, 80, 40 ), "Unequip", "box" );
				GUI.Button ( new Rect ( 245, 200, 80, 40 ), "Delete" );
			}
			else
			{
				GUI.Label ( new Rect ( 65, 200, 80, 40 ), "Equip", "box" );
				GUI.Button ( new Rect ( 155, 200, 80, 40 ), "Unequip" );
				GUI.Label ( new Rect ( 245, 200, 80, 40 ), "Delete", "box" );
			}
		}
		else
		{
			GUI.Label ( new Rect ( 65, 200, 80, 40 ), "Equip", "box" );
			GUI.Label ( new Rect ( 155, 200, 80, 40 ), "Unequip", "box" );
			GUI.Label ( new Rect ( 245, 200, 80, 40 ), "Delete", "box" );
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

				clickedItem = null;
				//placeInList = null;
			}
		}

		// if we want to show the currently equipped items
		if ( bShowEquipped )
		{
			GUI.Label ( new Rect ( 22, 65, buttonWidth, buttonHeight ), "Armor" );
			GUI.Label ( new Rect ( 200, 65, 50, buttonHeight ), "Weapon" );

			for ( int x = 0; x < equippedItems.Length; x++ )
			{
				// if we have items to show
				if ( equippedItems[x] != null )
				{
					if ( x == 3 )
					{
						if ( GUI.Button ( new Rect (200, 85, buttonWidth, buttonHeight ), x.ToString()) )
						{
							clickedItem = equippedItems[x];
						}
					}
					else
					{
						if ( GUI.Button ( new Rect (20 + (x * buttonWidth), 85, buttonWidth, buttonHeight ), x.ToString()) )
						{
							clickedItem = equippedItems[x];
						}
					}
				}
				// we dont have items to show
				else
					GUI.Label ( new Rect (20 + (x * buttonWidth), 85, buttonWidth, buttonHeight ), "none", "box");
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
							clickedItem = armor[x + y * inventoryCols];
							placeInList = x + y * inventoryCols;
							//print ( placeInList );
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
							clickedItem = weapons[x + y * inventoryCols];
							placeInList = x + y * inventoryCols;
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
	public void EquipArmor(int which)
	{
		ModifiedStats stats = GetComponent<ModifiedStats>();

		int dexBuff = 0;
		int strBuff = 0;
		int intBuff = 0;
		int armorBuff = 0;

		// place the armor in the appropriate slot, here we should also
		// move the equipped armor to the armor inventory
		if ( clickedItem.type == ItemScript.Type.helm )
		{
			if ( equippedItems[0] != null )
				armor.Add( equippedItems[0] );

			equippedItems[0] = clickedItem;
			clickedItem = null;
			armor.Remove ( armor[which] );
		}
		else if ( clickedItem.type == ItemScript.Type.chest )
		{
			if ( equippedItems[1] != null )
				armor.Add( equippedItems[1] );
				
			equippedItems[1] = clickedItem;
			clickedItem = null;
			armor.Remove ( armor[which] );
		}
		else if ( clickedItem.type == ItemScript.Type.legs )
		{
			if ( equippedItems[2] != null )
				armor.Add( equippedItems[2] );
				
			equippedItems[2] = clickedItem;
			clickedItem = null;
			armor.Remove ( armor[which] );
		}

		//equippedCount += 1;

		for ( int x = 0; x < equippedItems.Length; x++ )
		{
			if ( equippedItems[x] != null )
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

		//print ( "Dex Buff is " + stats._buffDEX );
		//print ( "Armor Buff is " + stats._armorClass );
	}

	// ------------------------------------------------------------------------------------------------------------
	// Move weapon from inventory to equipped items
	public void EquipWeapon(int which)
	{
		ModifiedStats stats = GetComponent<ModifiedStats>();

		if ( clickedItem.type == ItemScript.Type.weapon )
		{
			if ( equippedItems[3] != null )
				weapons.Add( equippedItems[3] );
				
			equippedItems[3] = clickedItem;
			clickedItem = null;
			weapons.Remove( weapons[which] );
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

		if ( !initialEquip )
			WaitToEquip();
	}
}
