using UnityEngine;
using System.Collections;

public class GenericNPC : MonoBehaviour {

	public string NPCName;

	public bool bShop;
	public bool bQuestGiver;

	public string Introduction;
	public int introWidth;
	public int introHeight;

	public string[] generalDialouges;
	public string[] shopDialouges;

	public int numberOfQuests;
	public string[] questDialouges;

	//----------------------------------------------------------------------------------------------------------------------------
	// Window Variables
	private Rect npcWindowRect = new Rect((Screen.width * 0.5f) - 200, (Screen.height * 0.75f), 400, 75);
	private const int NPCWindowID = 0;

	private Rect shopWindowRect = new Rect((Screen.width * 0.75f) - 200, (Screen.height * 0.5f) - 160, 400, 320);
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
			}
		}

		if ( buttonsToDraw == 2 && bShop )
		{
			if ( GUI.Button ( new Rect ( npcWindowRect.width * 0.25f - 40, npcWindowRect.height * 0.5f - 15, 80, 40 ), "Talk" ) )
			{
				bQuestGiving = false;
				bShopping = false;
				bConversation = true;
			}

			if ( GUI.Button ( new Rect ( npcWindowRect.width * 0.75f - 40, npcWindowRect.height * 0.5f - 15, 80, 40 ), "Shop" ) )
			{
				bConversation = false;
				bQuestGiving = false;
				bShopping = true;
			}

		}

		if ( buttonsToDraw == 2 && bQuestGiver )
		{
			if ( GUI.Button ( new Rect ( npcWindowRect.width * 0.25f - 40, npcWindowRect.height * 0.5f - 15, 80, 40 ), "Talk" ) )
			{
				bQuestGiving = false;
				bShopping = false;
				bConversation = true;
			}

			if ( GUI.Button ( new Rect ( npcWindowRect.width * 0.75f - 40, npcWindowRect.height * 0.5f - 15, 80, 40 ), "Quest" ) )
			{
				bConversation = false;
				bShopping = false;
				bQuestGiving = true;
			}
		}

		if ( buttonsToDraw == 3 )
		{
			if ( GUI.Button ( new Rect ( npcWindowRect.width * 0.2f - 40, npcWindowRect.height * 0.5f - 15, 80, 40 ), "Talk" ) )
			{
				bQuestGiving = false;
				bShopping = false;
				bConversation = true;
			}

			if ( GUI.Button ( new Rect ( npcWindowRect.width * 0.5f - 40, npcWindowRect.height * 0.5f - 15, 80, 40 ), "Shop" ) )
			{
				bConversation = false;
				bQuestGiving = false;
				bShopping = true;
			}

			if ( GUI.Button ( new Rect ( npcWindowRect.width * 0.8f - 40, npcWindowRect.height * 0.5f - 15, 80, 40 ), "Quest" ) )
			{
				bConversation = false;
				bShopping = false;
				bQuestGiving = true;
			}
		}
	}

	//----------------------------------------------------------------------------------------------------------------------------
	public void ShopWindow(int ID)
	{
		if ( GUI.Button ( new Rect ( shopWindowRect.width * 0.2f - 40, npcWindowRect.height * 0.8f - 15, 80, 40 ), "Buy" ) )
		{

		}

		if ( GUI.Button ( new Rect ( shopWindowRect.width * 0.8f - 40, npcWindowRect.height * 0.8f - 15, 80, 40 ), "Sell" ) )
		{
			
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

	}

	//----------------------------------------------------------------------------------------------------------------------------
	public void DescriptionWindow(int ID)
	{

	}

	//----------------------------------------------------------------------------------------------------------------------------
	public void SellWindow(int ID)
	{

	}

	//----------------------------------------------------------------------------------------------------------------------------
	// Update is called once per frame
	void Update () {
	
	}
}
