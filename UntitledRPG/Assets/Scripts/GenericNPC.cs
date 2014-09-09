using UnityEngine;
using System.Collections;

public class GenericNPC : MonoBehaviour {

	public string NPCName;

	public bool bShop;
	public bool bQuestGiver;

	public string Introduction;
	public int introWidth;
	public int introHeight;

	private Rect npcWindowRect = new Rect((Screen.width * 0.5f) - 200, (Screen.height * 0.75f), 400, 100);
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



	// Use this for initialization
	void Start () {

		player = GameObject.FindGameObjectWithTag("Player");
		playerInventory = player.GetComponent<Inventory>();
	
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
				if ( GUI.Button ( new Rect ( Screen.width * 0.5f, (Screen.height * 0.75f), 80, 40 ), "Talk" ) )
				{
					bIntro = true;
				}
			}

			if ( bIntro && !bMet )
			{
				// NPC introduction
				if ( GUI.Button ( new Rect ( Screen.width * 0.5f, (Screen.height * 0.75f), introWidth, introHeight ), Introduction ) )
				{
					bTalk = true;
					bMet = true;
				}
			}

			if ( bTalk )
			{
				npcWindowRect = GUI.Window (NPCWindowID, npcWindowRect, NPCWindow, NPCName );
			}
		}
	}

	public void NPCWindow( int ID )
	{

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
