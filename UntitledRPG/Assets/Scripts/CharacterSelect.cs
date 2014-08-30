using UnityEngine;
using System.Collections;

public class CharacterSelect : MonoBehaviour {

	public string playerName= "Name";
	public bool bMenu=true;
	public bool bSelect = false;
	public bool bBerSelect=false;
	public bool bRanSelect=false;
	public bool bNecSelect=false;
	public Transform Hero;
	public Transform Bers;
	public Transform Necr;
	public Transform Rang;

	void Awake()
	{
		DontDestroyOnLoad(Hero);

	}
	void OnGUI()
	{
		//Main Menu Screen
		if(bMenu)
		{
			if (GUI.Button (new Rect (Screen.width / 2 , (Screen.height / 2), 100, 50), "New"))
			{
				bMenu=false;
				bSelect=true;
			}
			if (GUI.Button (new Rect (Screen.width / 2 , (Screen.height / 2)+55, 100, 50), "Continue"))
			{
				bMenu=false;
			}
		}

		//Loads the next window in the "NEW" option
		if(bSelect)
		{
			if (GUI.Button (new Rect (Screen.width / 2 , (Screen.height / 2)-55, 100, 50), "Berserker"))
			{
				bSelect=false;
				bBerSelect=true;
			}
			if (GUI.Button (new Rect (Screen.width / 2 , (Screen.height / 2), 100, 50), "Necromancer"))
			{
				bSelect=false;
				bNecSelect=true;
			}
			if (GUI.Button (new Rect (Screen.width / 2 , (Screen.height / 2)+ 55, 100, 50), "Ranger"))
			{
				bSelect=false;
				bRanSelect=true;
			}
			if (GUI.Button (new Rect (Screen.width / 2 , (Screen.height / 2)+110, 100, 50), "Back"))
			{
				bSelect=false;
				bMenu=true;
			}
		}

		//Loads the preview windows for the classes
		if(bBerSelect)
		{
			playerName = GUI.TextField(new Rect(Screen.width/2,Screen.height/2,100,30), playerName,20);
			if (GUI.Button (new Rect (Screen.width / 2 , (Screen.height / 2)+55, 100, 50), "Confirm"))
			{
				Application.LoadLevel("Test");
				Instantiate(Bers, new Vector3(-1,0,0), Quaternion.identity);
				bBerSelect=false;
			}


			if (GUI.Button (new Rect (Screen.width / 2 , (Screen.height / 2)+110, 100, 50), "Back"))
			{
				bSelect=true;
				bBerSelect=false;
				playerName="Name";
			}

		}

		if(bNecSelect)
		{
			playerName = GUI.TextField(new Rect(Screen.width/2,Screen.height/2,100,30), playerName,20);
			if (GUI.Button (new Rect (Screen.width / 2 , (Screen.height / 2)+55, 100, 50), "Confirm"))
			{
				Application.LoadLevel("Test");
				Instantiate(Necr, new Vector3(-1,0,0), Quaternion.identity);
				bNecSelect=false;
			}


			if (GUI.Button (new Rect (Screen.width / 2 , (Screen.height / 2)+110, 100, 50), "Back"))
			{
				bSelect=true;
				bNecSelect=false;
				playerName="Name";
			}

		}

		if(bRanSelect)
		{

			playerName = GUI.TextField(new Rect(Screen.width/2,Screen.height/2,100,30), playerName,20);
			if (GUI.Button (new Rect (Screen.width / 2 , (Screen.height / 2)+55, 100, 50), "Confirm"))
			{
				Application.LoadLevel("Test");
				Instantiate(Rang, new Vector3(-1,0,0), Quaternion.identity);
				bRanSelect=false;
			}

			if (GUI.Button (new Rect (Screen.width / 2 , (Screen.height / 2)+110, 100, 50), "Back"))
			{
				bSelect=true;
				bRanSelect=false;
				playerName="Name";
			}

		}


	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
