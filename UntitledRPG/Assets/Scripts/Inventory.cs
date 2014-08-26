using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	public float offset;
	public Rect inventoryWindowRect = new Rect(10, 10, 170, 265);

	public float buttonWidth = 40;
	public float buttonHeight = 40;

	public int inventoryRows = 6;
	public int inventoryCols = 6;

	private bool displayInventory;
	private const int InventoryWindowID = 1;

	private List<Item> items = new List<Item>();

	// Use this for initialization
	void Start () {
	}

	void OnGUI()
	{
		if(displayInventory)
		{
			inventoryWindowRect = GUI.Window(InventoryWindowID, inventoryWindowRect, InventoryWindow, "Inventory");
		}
	}

	public void InventoryWindow(int ID)
	{
		int cnt = 0;

		for ( int y = 0; y < inventoryRows; y++ )
		{
			for ( int x = 0; x < inventoryCols; x++ )
			{
				if ( cnt < items.Count )
				{
					GUI.Button ( new Rect(5 + (x * buttonWidth), 20 + (y * buttonHeight), buttonWidth, buttonHeight ), ( x + y * inventoryCols).ToString());
				}
				else
					GUI.Label ( new Rect(5 + (x * buttonWidth), 20 + (y * buttonHeight), buttonWidth, buttonHeight ), "none", "box");

				cnt++;
			}
		}
	}

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
