using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenericNPC : MonoBehaviour {

	public string NPCName;

	public bool bShop;
	public bool bQuestGiver;

	public string Introduction;
	public int introWidth;
	public int introHeight;

	public string[] generalDialouges;

	public int[] cWeapons;
	public int[] unWeapons;
	public int[] rWeapons;
	public int[] cArmor;
	public int[] unArmor;
	public int[] rArmor;
	public string[] shopDialouges;
	private List<ItemScript> gearForSale = new List<ItemScript>();

	public int numberOfQuests;
	public string[] questDialouges;

	public int shopRows = 4;
	public int shopCols = 4;

	public int inventoryRows = 6;
	public int inventoryCols = 9;

	//----------------------------------------------------------------------------------------------------------------------------
	// Window Variables
	private Rect npcWindowRect = new Rect((Screen.width * 0.5f) - 200, (Screen.height * 0.75f), 400, 75);
	private const int NPCWindowID = 0;

	private Rect shopWindowRect = new Rect((Screen.width * 0.75f) - 150, (Screen.height * 0.5f) - 160, 300, 400);
	private const int ShopWindowID = 1;

	private Rect questWindowRect = new Rect((Screen.width * 0.75f) - 100, (Screen.height * 0.5f) - 160, 200, 320);
	private const int QuestWindowID = 2;

	private Rect inventoryWindowRect = new Rect((Screen.width * 0.25f) - 200, (Screen.height * 0.5f) - 160, 400, 320);
	private const int InventoryWindowID = 3;

	private Rect descriptionWindowRect = new Rect((Screen.width * 0.75f) - 200, (Screen.height * 0.5f) - 160, 400, 320);
	private const int DescriptionWindowID = 4;

	private Rect sellWindowRect = new Rect((Screen.width * 0.5f) - 100, (Screen.height * 0.5f) - 90, 200, 180);
	private const int SellWindowID = 5;


	//----------------------------------------------------------------------------------------------------------------------------
	// References
	private Inventory playerInventory;
	private Item itemList;
	private GameObject player;

	private ItemScript clickedItem;

	//----------------------------------------------------------------------------------------------------------------------------
	// Private Bools
	private bool inVicinity;
	private bool bTalk;
	private bool bIntro;
	private bool bMet;

	private bool bConversation;
	private bool bQuestGiving;
	private bool bShopping;
	private bool bSelling;
	private bool bBuying;

	private bool showWeapons;
	private bool showArmor;
	private bool showItems;

	private bool shopSet;

	//----------------------------------------------------------------------------------------------------------------------------
	// Private Ints
	private int buttonsToDraw = 0;

	//----------------------------------------------------------------------------------------------------------------------------
	// Use this for initialization
	void Start () {

		player = GameObject.FindGameObjectWithTag("Player");
		playerInventory = player.GetComponent<Inventory>();
		itemList = player.GetComponent<Item>();

		if ( bShop && bQuestGiver )
		{
			npcWindowRect = new Rect((Screen.width * 0.5f) - 150, (Screen.height * 0.75f), 300, 75);
			buttonsToDraw = 3;
		}
		else if ( bShop )
		{
			npcWindowRect = new Rect((Screen.width * 0.5f) - 100, (Screen.height * 0.75f), 200, 75);
			buttonsToDraw = 2;
		}
		else if ( bQuestGiver )
		{
			npcWindowRect = new Rect((Screen.width * 0.5f) - 100, (Screen.height * 0.75f), 200, 75);
			buttonsToDraw = 2;
		}
		else
		{
			npcWindowRect = new Rect((Screen.width * 0.5f) - 60, (Screen.height * 0.75f), 120, 75);
			buttonsToDraw = 1;
		}
	
	}

	//----------------------------------------------------------------------------------------------------------------------------
	public void SetShop()
	{
		for ( int x = 0; x < cWeapons.Length; x++ )
		{
			gearForSale.Add ( itemList.commonWeapons[cWeapons[x]] );
		}

		for ( int x = 0; x < unWeapons.Length; x++ )
		{
			gearForSale.Add ( itemList.uncommonWeapons[unWeapons[x]] );
		}

		for ( int x = 0; x < rWeapons.Length; x++ )
		{
			gearForSale.Add ( itemList.rareWeapons[rWeapons[x]] );
		}

		for ( int x = 0; x < cArmor.Length; x++ )
		{
			gearForSale.Add ( itemList.commonArmor[cArmor[x]] );
		}

		for ( int x = 0; x < unArmor.Length; x++ )
		{
			gearForSale.Add ( itemList.uncommonArmor[unArmor[x]] );
		}

		for ( int x = 0; x < rArmor.Length; x++ )
		{
			gearForSale.Add ( itemList.rareArmor[rArmor[x]] );
		}
	}

	//----------------------------------------------------------------------------------------------------------------------------
	void OnTriggerEnter2D(Collider2D other)
	{
		//print ( "Collided with" );
		if ( other.tag == "Player" )
		{
			inVicinity = true;
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		//print ( "Collided with" );
		if ( other.tag == "Player" )
		{
			inVicinity = false;
			bShopping = false;
			bQuestGiving = false;
			bConversation = false;

			showWeapons = false;
			showArmor = false;
			showItems = false;

			clickedItem = null;
		}
	}


	//----------------------------------------------------------------------------------------------------------------------------
	void OnGUI()
	{
		// We are close enough to begin conversation
		if ( inVicinity )
		{
			if ( !bIntro && !bMet )
			{
				// Hit the "talk" button to begin conversation
				if ( GUI.Button ( new Rect ( Screen.width * 0.5f - 40, (Screen.height * 0.75f), 80, 40 ), "Talk" ) )
				{
					bIntro = true;
				}
			}

			if ( bIntro && !bMet )
			{
				// NPC introduction
				if ( GUI.Button ( new Rect ( (Screen.width * 0.5f) - (introWidth * 0.5f), (Screen.height * 0.75f), introWidth, introHeight ), Introduction ) )
				{
					bTalk = true;
					bMet = true;
				}
			}

			if ( bTalk )
			{
				npcWindowRect = GUI.Window (NPCWindowID, npcWindowRect, NPCWindow, NPCName );

				if ( bConversation )
				{
					// Begin Conversation
				}

				if ( bShopping )
				{
					// Begin Shopping
					shopWindowRect = GUI.Window (ShopWindowID, shopWindowRect, ShopWindow, "Shop" );

					if ( bSelling ) 
						inventoryWindowRect = GUI.Window (InventoryWindowID, inventoryWindowRect, InventoryWindow, "Inventory" );

					if ( clickedItem != null )
					{
						if ( bBuying )
							sellWindowRect = GUI.Window (SellWindowID, sellWindowRect, SellWindow, "Buy" );

						if ( bSelling )
							sellWindowRect = GUI.Window (SellWindowID, sellWindowRect, SellWindow, "Sell" );
					}
				}

				if ( bQuestGiving )
				{
					// Begin giving quests
					questWindowRect = GUI.Window (QuestWindowID, questWindowRect, QuestWindow, "Quest" );
				}
			}
		}
	}


	//----------------------------------------------------------------------------------------------------------------------------
	public void NPCWindow( int ID )
	{
		if ( buttonsToDraw == 1 )
		{
			if ( GUI.Button ( new Rect ( npcWindowRect.width * 0.5f - 40, npcWindowRect.height * 0.5f - 15, 80, 40 ), "Talk" ) )
			{
				bQuestGiving = false;
				bShopping = false;
				bConversation = true;
				clickedItem = null;

				showWeapons = false;
				showArmor = false;
				showItems = false;
			}
		}

		if ( buttonsToDraw == 2 && bShop )
		{
			if ( GUI.Button ( new Rect ( npcWindowRect.width * 0.25f - 40, npcWindowRect.height * 0.5f - 15, 80, 40 ), "Talk" ) )
			{
				bQuestGiving = false;
				bShopping = false;
				bConversation = true;
				clickedItem = null;

				showWeapons = false;
				showArmor = false;
				showItems = false;
			}

			if ( GUI.Button ( new Rect ( npcWindowRect.width * 0.75f - 40, npcWindowRect.height * 0.5f - 15, 80, 40 ), "Shop" ) )
			{
				bConversation = false;
				bQuestGiving = false;
				bShopping = true;
				clickedItem = null;

				showWeapons = false;
				showArmor = false;
				showItems = false;
			}

		}

		if ( buttonsToDraw == 2 && bQuestGiver )
		{
			if ( GUI.Button ( new Rect ( npcWindowRect.width * 0.25f - 40, npcWindowRect.height * 0.5f - 15, 80, 40 ), "Talk" ) )
			{
				bQuestGiving = false;
				bShopping = false;
				bConversation = true;
				clickedItem = null;

				showWeapons = false;
				showArmor = false;
				showItems = false;
			}

			if ( GUI.Button ( new Rect ( npcWindowRect.width * 0.75f - 40, npcWindowRect.height * 0.5f - 15, 80, 40 ), "Quest" ) )
			{
				bConversation = false;
				bShopping = false;
				bQuestGiving = true;
				clickedItem = null;

				showWeapons = false;
				showArmor = false;
				showItems = false;
			}
		}

		if ( buttonsToDraw == 3 )
		{
			if ( GUI.Button ( new Rect ( npcWindowRect.width * 0.2f - 40, npcWindowRect.height * 0.5f - 15, 80, 40 ), "Talk" ) )
			{
				bQuestGiving = false;
				bShopping = false;
				bConversation = true;
				clickedItem = null;

				showWeapons = false;
				showArmor = false;
				showItems = false;
			}

			if ( GUI.Button ( new Rect ( npcWindowRect.width * 0.5f - 40, npcWindowRect.height * 0.5f - 15, 80, 40 ), "Shop" ) )
			{
				bConversation = false;
				bQuestGiving = false;
				bShopping = true;
				clickedItem = null;

				showWeapons = false;
				showArmor = false;
				showItems = false;
			}

			if ( GUI.Button ( new Rect ( npcWindowRect.width * 0.8f - 40, npcWindowRect.height * 0.5f - 15, 80, 40 ), "Quest" ) )
			{
				bConversation = false;
				bShopping = false;
				bQuestGiving = true;
				clickedItem = null;

				showWeapons = false;
				showArmor = false;
				showItems = false;
			}
		}
	}

	//----------------------------------------------------------------------------------------------------------------------------
	public void ShopWindow(int ID)
	{
		int cnt = 0;

		if ( GUI.Button ( new Rect ( shopWindowRect.width * 0.2f - 40, npcWindowRect.height * 0.8f - 15, 80, 40 ), "Buy" ) )
		{
			bBuying = true;
			bSelling = false;

			showWeapons = false;
			showArmor = false;
			showItems = false;
		}

		if ( GUI.Button ( new Rect ( shopWindowRect.width * 0.8f - 40, npcWindowRect.height * 0.8f - 15, 80, 40 ), "Sell" ) )
		{
			bSelling = true;
			bBuying = false;

			showWeapons = false;
			showArmor = false;
			showItems = false;
		}

		if ( bBuying )
		{
			for ( int y = 0; y < shopRows; y++ )
			{
				for ( int x = 0; x < shopCols; x++ )
				{
					// if we have items to show
					if ( cnt < gearForSale.Count )
					{
						if ( GUI.Button ( new Rect(20 + (x * 40), 100 + (y * 40), 40, 40 ), ( x + y * shopCols).ToString()) )
						{
							clickedItem = gearForSale[x];
						}
					}
					
					cnt++;
				}
			}

			if ( clickedItem != null )
			{
				GUI.Label ( new Rect ( 10, 200, 200, 50 ), "Name: " + clickedItem.Name );
				GUI.Label ( new Rect ( 10, 215, 200, 50 ), "Description: " + clickedItem.description );
				GUI.Label ( new Rect ( 10, 245, 200, 50 ), "Dex Boost: " + clickedItem.dexBoost );
				GUI.Label ( new Rect ( 10, 260, 200, 50 ), "Str Boost: " + clickedItem.strBoost );
				GUI.Label ( new Rect ( 10, 275, 200, 50 ), "Int Boost: " + clickedItem.intBoost );
				GUI.Label ( new Rect ( 10, 290, 200, 50 ), "Armor Class: " + clickedItem.armorClass );
				GUI.Label ( new Rect ( 10, 305, 200, 50 ), "Damage: " + clickedItem.damage );
				GUI.Label ( new Rect ( 10, 320, 200, 50 ), "Type: " + clickedItem.type );
				GUI.Label ( new Rect ( 10, 335, 200, 50 ), "Rarity: " + clickedItem.rarity );
			}
		}

		if ( bSelling )
		{
			if ( clickedItem != null )
			{
				GUI.Label ( new Rect ( 10, 200, 200, 50 ), "Name: " + clickedItem.Name );
				GUI.Label ( new Rect ( 10, 215, 200, 50 ), "Description: " + clickedItem.description );
				GUI.Label ( new Rect ( 10, 245, 200, 50 ), "Dex Boost: " + clickedItem.dexBoost );
				GUI.Label ( new Rect ( 10, 260, 200, 50 ), "Str Boost: " + clickedItem.strBoost );
				GUI.Label ( new Rect ( 10, 275, 200, 50 ), "Int Boost: " + clickedItem.intBoost );
				GUI.Label ( new Rect ( 10, 290, 200, 50 ), "Armor Class: " + clickedItem.armorClass );
				GUI.Label ( new Rect ( 10, 305, 200, 50 ), "Damage: " + clickedItem.damage );
				GUI.Label ( new Rect ( 10, 320, 200, 50 ), "Type: " + clickedItem.type );
				GUI.Label ( new Rect ( 10, 335, 200, 50 ), "Rarity: " + clickedItem.rarity );
			}
		}
	}

	//----------------------------------------------------------------------------------------------------------------------------
	public void QuestWindow(int ID)
	{
		for ( int x = 0; x < numberOfQuests; x++ )
		{
			if ( GUI.Button ( new Rect (questWindowRect.width * 0.5f - 40, 30 + (x * 50), 80, 40 ), "Quest " + (x+1) ) )
			{

			}
		}
	}

	//----------------------------------------------------------------------------------------------------------------------------
	public void InventoryWindow(int ID)
	{
		int cnt = 0;
		
		if ( GUI.Button ( new Rect ( inventoryWindowRect.width * 0.2f - 40, inventoryWindowRect.height * 0.15f - 25, 80, 40 ), "Weapons" ) )
		{
			showWeapons = true;
			showArmor = false;
			showItems = false;
			clickedItem = null;
		}
		
		if ( GUI.Button ( new Rect ( inventoryWindowRect.width * 0.5f - 40, inventoryWindowRect.height * 0.15f - 25, 80, 40 ), "Armor" ) )
		{
			showWeapons = false;
			showArmor = true;
			showItems = false;
			clickedItem = null;
		}

		if ( GUI.Button ( new Rect ( inventoryWindowRect.width * 0.8f - 40, inventoryWindowRect.height * 0.15f - 25, 80, 40 ), "Items" ) )
		{
			showWeapons = false;
			showArmor = false;
			showItems = true;
			clickedItem = null;
		}

		if ( showWeapons )
		{
			for ( int y = 0; y < inventoryRows; y++ )
			{
				for ( int x = 0; x < inventoryCols; x++ )
				{
					// if we have items to show
					if ( cnt < playerInventory.weapons.Count )
					{
						if ( GUI.Button ( new Rect(20 + (x * 40), 70 + (y * 40), 40, 40 ), ( x + y * inventoryCols).ToString()) )
						{
							clickedItem = playerInventory.weapons[x + y * inventoryCols];
						}
					}
					// we dont have items to show
					else
						GUI.Label ( new Rect(20 + (x * 40), 70 + (y * 40), 40, 40 ), "none", "box");
					
					cnt++;
				}
			}
		}

		if ( showArmor )
		{
			for ( int y = 0; y < inventoryRows; y++ )
			{
				for ( int x = 0; x < inventoryCols; x++ )
				{
					// if we have items to show
					if ( cnt < playerInventory.armor.Count )
					{
						if ( GUI.Button ( new Rect(20 + (x * 40), 70 + (y * 40), 40, 40 ), ( x + y * inventoryCols).ToString()) )
						{
							clickedItem = playerInventory.armor[x + y * inventoryCols];
						}
					}
					// we dont have items to show
					else
						GUI.Label ( new Rect(20 + (x * 40), 70 + (y * 40), 40, 40 ), "none", "box");
					
					cnt++;
				}
			}
		}

		if ( showItems )
		{
			for ( int y = 0; y < inventoryRows; y++ )
			{
				for ( int x = 0; x < inventoryCols; x++ )
				{
					// if we have items to show
					if ( cnt < playerInventory.items.Count )
					{
						if ( GUI.Button ( new Rect(20 + (x * 40), 70 + (y * 40), 40, 40 ), ( x + y * inventoryCols).ToString()) )
						{
							clickedItem = playerInventory.items[x + y * inventoryCols];
						}
					}
					// we dont have items to show
					else
						GUI.Label ( new Rect(20 + (x * 40), 70 + (y * 40), 40, 40 ), "none", "box");
					
					cnt++;
				}
			}
		}
	}

	//----------------------------------------------------------------------------------------------------------------------------
	public void DescriptionWindow(int ID)
	{

	}

	//----------------------------------------------------------------------------------------------------------------------------
	public void SellWindow(int ID)
	{
		if ( clickedItem != null )
		{
			if ( bBuying )
			{
				GUI.Label ( new Rect ( 10, 15, 200, 50 ), "Buy " + clickedItem.Name + " for X gold?" );
				
				if ( GUI.Button ( new Rect ( 60, 75, 80, 40 ), "Buy" ) )
				{
					if ( clickedItem.type == ItemScript.Type.weapon )
					{
						playerInventory.weapons.Add(clickedItem);
					}
					else
						playerInventory.armor.Add(clickedItem);

					clickedItem = null;
				}
				
				if ( GUI.Button ( new Rect ( 60, 120, 80, 40 ), "Cancel" ) )
				{
					clickedItem = null;
				}
			}

			if ( bSelling )
			{
				GUI.Label ( new Rect ( 10, 15, 200, 50 ), "Sell " + clickedItem.Name + " for X gold?" );
				
				if ( GUI.Button ( new Rect ( 60, 75, 80, 40 ), "Sell" ) )
				{
					clickedItem = null;
				}
				
				if ( GUI.Button ( new Rect ( 60, 120, 80, 40 ), "Cancel" ) )
				{
					clickedItem = null;
				}
			}
		}
	}

	//----------------------------------------------------------------------------------------------------------------------------
	// Update is called once per frame
	void Update () {

		if ( !shopSet && playerInventory.initialEquip )
		{
			SetShop();
			shopSet = true;
		}
	
	}
}
