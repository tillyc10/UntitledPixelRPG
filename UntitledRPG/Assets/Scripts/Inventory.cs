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
	private List<Item> items = new List<Item>();
	private List<Item> weapons = new List<Item>();
	private List<Item> armor = new List<Item>();

	// Array holding the inventory selectors
	private string[] Selector = new string[4];

	// Array to hold the equipped items
	private Item[] equippedItems = new Item[4];

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
			}

			Destroy( other.gameObject );
		}
	}

	// Drawing to the HUD
	void OnGUI()
	{
		if(displayInventory)
		{
			inventoryWindowRect = GUI.Window(InventoryWindowID, inventoryWindowRect, InventoryWindow, "Inventory");
		}
	}

	// The inventory window
	public void InventoryWindow(int ID)
	{
		int cnt = 0;

		// Drawing the selection buttons to view different types of items in the inventory
		for ( int topRow = 0; topRow < selectorRows; topRow++ )
		{
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

		if ( bShowEquipped )
		{
			for ( int x = 0; x < equippedItems.Length; x++ )
			{
				//print ( equippedItems[x]);
				if ( equippedItems[x] != null )
				{
					
				}
				else
					GUI.Label ( new Rect (20 + (x * buttonWidth), 65, buttonWidth, buttonHeight ), "none", "box");
			}
		}

		if ( bShowItems )
		{
			for ( int y = 0; y < inventoryRows; y++ )
			{
				for ( int x = 0; x < inventoryCols; x++ )
				{
					if ( cnt < items.Count )
					{
						GUI.Button ( new Rect(20 + (x * buttonWidth), 65 + (y * buttonHeight), buttonWidth, buttonHeight ), ( x + y * inventoryCols).ToString());
					}
					else
						GUI.Label ( new Rect(20 + (x * buttonWidth), 65 + (y * buttonHeight), buttonWidth, buttonHeight ), "none", "box");
					
					cnt++;
				}
			}
		}

		if ( bShowArmor )
		{
			for ( int y = 0; y < inventoryRows; y++ )
			{
				for ( int x = 0; x < inventoryCols; x++ )
				{
					if ( cnt < armor.Count )
					{
						GUI.Button ( new Rect(20 + (x * buttonWidth), 65 + (y * buttonHeight), buttonWidth, buttonHeight ), ( x + y * inventoryCols).ToString());
					}
					else
						GUI.Label ( new Rect(20 + (x * buttonWidth), 65 + (y * buttonHeight), buttonWidth, buttonHeight ), "none", "box");
					
					cnt++;
				}
			}
		}

		if ( bShowWeapons )
		{
			for ( int y = 0; y < inventoryRows; y++ )
			{
				for ( int x = 0; x < inventoryCols; x++ )
				{
					if ( cnt < weapons.Count )
					{
						GUI.Button ( new Rect(20 + (x * buttonWidth), 65 + (y * buttonHeight), buttonWidth, buttonHeight ), ( x + y * inventoryCols).ToString());
					}
					else
						GUI.Label ( new Rect(20 + (x * buttonWidth), 65 + (y * buttonHeight), buttonWidth, buttonHeight ), "none", "box");
					
					cnt++;
				}
			}
		}
	}

	// To display or not too display...
	public void ToggleInventoryWindow()
	{
		if ( Input.GetKeyUp(KeyCode.I) )
		{
			displayInventory = !displayInventory;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
		ToggleInventoryWindow();

	}
}
