using UnityEngine;
using System.Collections;

public class Berserker : MonoBehaviour
{
	public int baseSTR=2;
	public int baseDEX=1;
	public int baseINT=1;

	private int buffSTR;
	private int buffDEX;
	private int buffINT;

	//Non-additive variables
	private int AC;
	private float damage;
	public int level=1;
	public int health =20;
	public int curHealth=20;
	public int experience;
	public int expToLevel=20;
	public int rage=25;
	public int curRage=25;



	//Getters & Setters for Stats
#region
	//Armor class
	public int ArmorClass 
	{
		get{ return AC;}
		set{ AC = value;}
	}
	//weapon damage
	public float Damage 
	{
		get{ return damage;}
		set{ damage = value;}
	}
	//STAT MODIFIERS
	//Strength Modifier
	public int BuffSTR 
	{
		get{ return buffSTR;}
		set{ buffSTR = value;}
	}

	//Dexterity Modifier
	public int BuffDEX
	{
		get{ return buffDEX;}
		set{ buffDEX = value;}
	}

	//Intelligence Modifier
	public int BuffINT 
	{
		get{ return buffINT;}
		set{ buffINT = value;}
	}

	//Strength total
	public int TotalSTR 
	{
		get{ return baseSTR + buffSTR;}
	}

	//Dexterity total
	public int TotalDEX 
	{
		get{ return baseDEX + buffDEX;}
	}

	//Intelligence total
	public int TotalINT 
	{
		get{ return baseINT + buffINT;}
	}
#endregion

	//Leveling Up function
	private void LevelUp()
	{
		level++;
		baseSTR+=2;
		baseINT++;

		//Checks divisibilty of 5 and adds Dex accordingly
		if((level%5) == 0)
			baseDEX+=3;
		else
			baseDEX++;
		//Health scaling
		if(level < 5)
			health+=20;
		else if(level > 4 && level < 10){
			health+=40;
			rage=25;}
		else if(level > 9 && level < 15){
		    health+=80;
			rage=50;}
		else if(level >14 && level <20){
			health+=160;
			rage=75;}
		else if(level > 19 && level <25){
			health+=320;
			rage=100;}
		if(level == 25){
			health+=640;
			rage=100;}

		curHealth = health;
		curRage = rage;
	}
	// Use this for initialization
	void Start ()
	{
	
	}

	// Update is called once per frame
	void Update ()
	{
		if(experience >= expToLevel)
		{
			if(level < 25)
			{
				LevelUp();
				expToLevel=(int)(expToLevel*1.5f);
			}
		}
	}
}
