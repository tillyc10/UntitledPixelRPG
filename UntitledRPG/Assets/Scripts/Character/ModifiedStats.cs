using UnityEngine;
using System.Collections;

public class ModifiedStats : MonoBehaviour{
	public int _buffSTR;
	public int _buffDEX;
	public int _buffINT;
	public int _armorClass;
	public float _baseDamage;
	public int experience;
	public int expToLevel=20;
	public int level;

	public bool bBer;
	public bool bNec;
	public bool bRan;

	public ModifiedStats()
	{
		_buffSTR = 0;
		_buffDEX = 0;
		_buffINT = 0;
		_armorClass = 0;
		_baseDamage = 0.0f;
		experience=0;
	}
	
	//set/get
	public int TotalSTR() 
	{
		Berserker bSTR = GetComponent<Berserker>();
		Ranger rSTR = GetComponent<Ranger>();
		Necromancer nSTR = GetComponent<Necromancer>();

		//GameObject bClass = GameObject.FindGameObjectWithTag("Player");

		if(bBer==true)
		{
			return _buffSTR+ bSTR.baseSTR;
		}
		else if(bNec==true)
		{
			return _buffSTR + nSTR.baseSTR;
		}
		else if(bRan==true)
		{
			return _buffSTR + rSTR.baseSTR;
		}
		else
			return 0;
	}
	
	//Dexterity total
	public int TotalDEX() 
	{
		Berserker bDEX = GetComponent<Berserker>();
		Ranger rDEX = GetComponent<Ranger>();
		Necromancer nDEX = GetComponent<Necromancer>();

		//GameObject bClass = GameObject.FindGameObjectWithTag("Player");
		
		if(bBer)
		{
			return _buffSTR+bDEX.baseDEX;
		}
		else if(bNec)
		{
			return _buffSTR + nDEX.baseDEX;
		}
		else if(bRan)
		{
			return _buffSTR + rDEX.baseDEX;
		}
		else
			return 0;
		
	}
	
	//Intelligence total
	public int TotalINT() 
	{
		Berserker bINT = GetComponent<Berserker>();
		Ranger rINT = GetComponent<Ranger>();
		Necromancer nINT = GetComponent<Necromancer>();

		//GameObject bClass = GameObject.FindGameObjectWithTag("Player");
		
		if(bBer)
		{
			return _buffSTR + bINT.baseINT;
		}
		else if(bNec)
		{
			return _buffSTR + nINT.baseINT;
		}
		else if(bRan)
		{
			return _buffSTR + rINT.baseINT;
		}
		else
			return 0;
	}
	void Update()
	{
		if(experience >= expToLevel)
			level++;
	}

}
