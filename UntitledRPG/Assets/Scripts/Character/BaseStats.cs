using UnityEngine;
using System.Collections;

public class BaseStats : MonoBehaviour{
	public int _buffValue;			//Value of armor/weapon buff+base
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
	}
	
	//set/get
	public int TotalSTR() 
	{
		Berserker STR = GetComponent<Berserker>();
		return _buffSTR + STR.baseSTR;
	}
	
	//Dexterity total
	public int TotalDEX() 
	{
		Berserker DEX = GetComponent<Berserker>();
		return _buffDEX + DEX.baseDEX;
		
	}
	
	//Intelligence total
	public int TotalINT() 
	{
		Berserker INT = GetComponent<Berserker>();
		return _buffINT + INT.baseINT;
	}

}
