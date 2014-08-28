using UnityEngine;
using System.Collections;

public class Necromancer : MonoBehaviour {

	public int baseSTR=0;
	public int baseDEX=0;
	public int baseINT=0;
	
	//Non-additive variables
	public int level=0;
	public int skillKnown=0;
	
	//Leveling Up function
	private void LevelUp()
	{
		level++;
		baseINT+=2;
		baseSTR++;
		
		//Typecasts to allow the class to access HP and Resource.
		PlayerHealth health = GetComponent<PlayerHealth>();
		PlayerResource darkEnergy = GetComponent<PlayerResource>();
		
		
		//Checks divisibilty of 5 and adds Dex accordingly
		if((level%5) == 0){
			baseSTR+=3;
			skillKnown++;}
		else
			baseSTR++;
		
		//Health scaling
		if(level < 5)
			health.maxHealth+=20;
		else if(level > 4 && level < 10){
			health.maxHealth+=40;
			darkEnergy.maxResource=25;}
		else if(level > 9 && level < 15){
			health.maxHealth+=80;
			darkEnergy.maxResource=50;}
		else if(level >14 && level <20){
			health.maxHealth+=160;
			darkEnergy.maxResource=75;}
		else if(level > 19 && level <25){
			health.maxHealth+=320;
			darkEnergy.maxResource=100;}
		if(level == 25){
			health.maxHealth+=640;
			darkEnergy.maxResource=100;}
		
		health.curHealth= health.maxHealth;
		darkEnergy.curResource = darkEnergy.maxResource;
	}
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(level < 25)
		{
			BaseStats exp = GetComponent<BaseStats>();
			if(exp.experience >= exp.expToLevel){
				LevelUp();
				exp.expToLevel = (int)(exp.expToLevel * 1.1f);}
		}
	}
}
