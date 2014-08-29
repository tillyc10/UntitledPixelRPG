using UnityEngine;
using System.Collections;
[System.Serializable]

public class Item : MonoBehaviour {
	
	public string Name;
	public string Description;
	public int dexBoost;
	public int strBoost;
	public int intBoost;
	public int armorClass;
	public float damage;
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

	// How much of this item do we have?
	private int count;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
