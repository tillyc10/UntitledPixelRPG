using UnityEngine;
using System.Collections;

public class GenericNPC : MonoBehaviour {

	public string NPCName;

	public bool bShop;
	public bool bQuestGiver;

	public string Introduction;
	public int introWidth;
	public int introHeight;

	private Rect npcWindowRect = new Rect((Screen.width * 0.5f) - 200, (Screen.height * 0.75f), 400, 75);
	private const int NPCWindowID = 0;

	public string[] generalDialouges;
	public string[] shopDialouges;
	public string[] questDialouges;
	
	// References
	private Inventory playerInventory;
	private GameObject player;

	private bool inVicinity;
	private bool bTalk;
	private bool bIntro;
	private bool bMet;

	private bool bConversation;
	private bool bQuestGiving;
	private bool bShopping;

	private int buttonsToDraw = 0;



	// Use this for initialization
	void Start () {

		player = GameObject.FindGameObjectWithTag("Player");
		playerInventory = player.GetComponent<Inventory>();

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
		}
	}

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
				}

				if ( bQuestGiving )
				{
					// Begin giving quests
				}
			}
		}
	}

	public void NPCWindow( int ID )
	{
		if ( buttonsToDraw == 1 )
		{
			if ( GUI.Button ( new Rect ( npcWindowRect.width * 0.5f - 40, npcWindowRect.height * 0.5f - 15, 80, 40 ), "Talk" ) )
				bConversation = true;
		}

		if ( buttonsToDraw == 2 && bShop )
		{
			if ( GUI.Button ( new Rect ( npcWindowRect.width * 0.25f - 40, npcWindowRect.height * 0.5f - 15, 80, 40 ), "Talk" ) )
				bConversation = true;

			if ( GUI.Button ( new Rect ( npcWindowRect.width * 0.75f - 40, npcWindowRect.height * 0.5f - 15, 80, 40 ), "Shop" ) )
				bShopping = true;

		}

		if ( buttonsToDraw == 2 && bQuestGiver )
		{
			if ( GUI.Button ( new Rect ( npcWindowRect.width * 0.25f - 40, npcWindowRect.height * 0.5f - 15, 80, 40 ), "Talk" ) )
				bConversation = true;

			if ( GUI.Button ( new Rect ( npcWindowRect.width * 0.75f - 40, npcWindowRect.height * 0.5f - 15, 80, 40 ), "Quest" ) )
				bQuestGiving = true;
		}

		if ( buttonsToDraw == 3 )
		{
			if ( GUI.Button ( new Rect ( npcWindowRect.width * 0.2f - 40, npcWindowRect.height * 0.5f - 15, 80, 40 ), "Talk" ) )
				bConversation = true;

			if ( GUI.Button ( new Rect ( npcWindowRect.width * 0.5f - 40, npcWindowRect.height * 0.5f - 15, 80, 40 ), "Shop" ) )
				bShopping = true;

			if ( GUI.Button ( new Rect ( npcWindowRect.width * 0.8f - 40, npcWindowRect.height * 0.5f - 15, 80, 40 ), "Quest" ) )
				bQuestGiving = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
