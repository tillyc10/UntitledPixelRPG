using UnityEngine;
using System.Collections;

public class CharacterSelect : MonoBehaviour {

	public string playerName= "Name";
	public bool bMenu=true;
	public bool bSelect = false;
	public bool bBerSelect=false;
	public bool bRanSelect=false;
	public bool bNecSelect=false;


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
			if (GUI.Button (new Rect (Screen.width / 2 , (Screen.height / 2)+110, 100, 50), "Back"))
			{
				bSelect=true;
				bBerSelect=false;
				playerName=string.Empty;
			}
			if (GUI.Button (new Rect (Screen.width / 2 , (Screen.height / 2)+55, 100, 50), "Confirm"))
			{
				Application.LoadLevel("Test");
			}
		}

		if(bNecSelect)
		{
			playerName = GUI.TextField(new Rect(Screen.width/2,Screen.height/2,100,30), playerName,20);
			if (GUI.Button (new Rect (Screen.width / 2 , (Screen.height / 2)+110, 100, 50), "Back"))
			{
				bSelect=true;
				bNecSelect=false;
				playerName=string.Empty;
			}
		}

		if(bRanSelect)
		{
			playerName = GUI.TextField(new Rect(Screen.width/2,Screen.height/2,100,30), playerName,20);
			if (GUI.Button (new Rect (Screen.width / 2 , (Screen.height / 2)+110, 100, 50), "Back"))
			{
				bSelect=true;
				bRanSelect=false;
				playerName=string.Empty;
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
