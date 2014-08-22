﻿using UnityEngine;
using System.Collections;

public class NPC : MonoBehaviour {

	private bool bTalk = false;
	private bool bTalkShop = false;
	private int bAdvance;
	private int bShop;
	private float counter;

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		print ( "Collided with" );
		if ( other.tag == "Player" )
		{
			bTalk = true;
			bTalkShop = true;
		}
	}

	void OnGUI()
	{
		if (bTalkShop) 
		{
			if (GUI.Button (new Rect (Screen.width / 2 - 50, (Screen.height / 5) * 3, 100, 50), "Shop"))
			{
				bShop++;
				bTalkShop = false;
				bTalk = false;
				counter = 0;
			} 
			else
				counter += Time.deltaTime;

		}
		if(bShop == 1)
		{
			if( GUI.Button( new Rect( Screen.width/2 - 50, (Screen.height/5) * 3, 100, 50 ), "Buy"))
			{
				bShop = 2;
			}
			else					
				counter += Time.deltaTime;

			if( GUI.Button( new Rect( Screen.width/2 - 50, (Screen.height/4) * 3, 100, 50 ), "Sell"))
			{
				bShop = 3;
			}				
			else
				counter += Time.deltaTime;
		}
		if(bShop == 2) 
		{
			if( GUI.Button( new Rect( Screen.width/2 - 125, (Screen.height/5) * 3, 250, 50 ), "Sorry you don't have any money"))
			{
				bShop = 0;
			}
		}
		if (bShop == 3) 
		{
			if( GUI.Button( new Rect( Screen.width/2 - 125, (Screen.height/5) * 3, 260, 50 ), "Sorry you don't have an Inventory just yet"))
			{
				bShop = 0;
			}
		}
		if ( counter >= 5 )
		{
			bShop = 0;
			counter = 0;
		}

		if ( bTalk )
		{

			if( GUI.Button( new Rect( Screen.width/2 - 50, (Screen.height/4) * 3, 100, 50 ), "Hello!"))
			{
				Debug.Log ("Hahahahaha");
				bTalk = false;
				bAdvance += 1;
				counter = 0;
			}
			else
				counter += Time.deltaTime;

			if ( counter >= 5 )
			{
				bTalk = false;
				bTalkShop = false;
				counter = 0;
			}
		}

		if ( bAdvance == 1 )
		{
			if ( GUI.Button ( new Rect( Screen.width/2 - 125, (Screen.height/4) *3, 250, 50), "Welcome to this test!"))
			{
				bAdvance += 1;
			}
		}
		else if ( bAdvance == 2 )
		{
			if ( GUI.Button ( new Rect( Screen.width/2 - 125, (Screen.height/4) *3, 250, 50), "The future is bright for the grim!"))
			{
				bAdvance += 1;
			}
		}
		else if ( bAdvance == 3 )
		{
			if ( GUI.Button ( new Rect( Screen.width/2 - 50, (Screen.height/4) *3, 100, 50), "Goodbye!"))
			{
				bAdvance = 0;
			}
			else
				counter += Time.deltaTime;
			
			if ( counter >= 5 )
			{
				bAdvance = 0;
				counter = 0;
			}
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}