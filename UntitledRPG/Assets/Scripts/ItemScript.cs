using UnityEngine;
using System.Collections;

public class ItemScript : ScriptableObject {

	public string Name;
	public string description;
	public int dexBoost;
	public int strBoost;
	public int intBoost;
	public float damage;
	public int armorClass;
	public Rarity rarity;
	public Type type;
	
	public enum  Type {
		helm,
		arms,
		chest,
		legs,
		weapon,
		item
	}
	
	public enum Rarity {
		common,
		uncommon,
		rare,
		relic
	}

	public void init( string sName, string desc, int dBoost, int sBoost, int iBoost, float fDamage, int aClass, Rarity rare, Type kind )
	{
		this.Name = sName;
		this.description = desc;
		this.dexBoost = dBoost;
		this.strBoost = sBoost;
		this.intBoost = iBoost;
		this.damage = fDamage;
		this.armorClass = aClass;
		this.rarity = rare;
		this.type = kind;
	}

	public static ItemScript CreateInstance( string sName, string desc, int dBoost, int sBoost, int iBoost, float fDamage, int aClass, Rarity rare, Type kind )
	{
		var item = ScriptableObject.CreateInstance<ItemScript>();
		item.init( sName, desc, dBoost, sBoost, iBoost, fDamage, aClass, rare, kind );
		return item;
	}
}
