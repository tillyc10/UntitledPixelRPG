using UnityEngine;
using System.Collections;
[System.Serializable]

public class Item : MonoBehaviour {
	
	public string Name;
	public string Description;
	public Rarity rarity;

	public enum Rarity {
		common,
		uncommon,
		rare,
		relic
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
