using UnityEngine;
using System.Collections;

public class BaseStats : MonoBehaviour{
	public int _buffSTR;
	public int _buffDEX;
	public int _buffINT;
	public int _armorClass;
	public float _baseDamage;
	public int experience;
	public int expToLevel=20;

	public BaseStats()
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
		return _buffSTR + bSTR.baseSTR + rSTR.baseSTR + nSTR.baseSTR;
	}
	
	//Dexterity total
	public int TotalDEX() 
	{
		Berserker bDEX = GetComponent<Berserker>();
		Ranger rDEX = GetComponent<Ranger>();
		Necromancer nDEX = GetComponent<Necromancer>();
		return _buffDEX + bDEX.baseDEX + rDEX.baseDEX + nDEX.baseDEX;
		
	}
	
	//Intelligence total
	public int TotalINT() 
	{
		Berserker bINT = GetComponent<Berserker>();
		Ranger rINT = GetComponent<Ranger>();
		Necromancer nINT = GetComponent<Necromancer>();
		return _buffINT + bINT.baseINT + rINT.baseINT + nINT.baseINT;
	}

}
