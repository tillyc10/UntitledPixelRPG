using UnityEngine;
using System.Collections;

public class BerserkerHealth : MonoBehaviour 
{
	public float HpBarLength; 
	// Use this for initialization
	void Start () 
	{
		HpBarLength = Screen.width / 4;
	}
	
	// Update is called once per frame
	void Update () 
	{
		AdjustCurrentHealth (0);
	}
	void OnGUI()
	{
		Berserker health = GetComponent<Berserker>();
		GUI.Box (new Rect(10,(Screen.height/10)*9,HpBarLength, 20), "HP: " + health.curHealth + "/" + health.health);
	}
	public void AdjustCurrentHealth(int adj)
	{
		Berserker health = GetComponent<Berserker>();
		health.curHealth += adj;
		
		if (health.curHealth < 0) 
		{
			health.curHealth = 0;
		}
		if (health.curHealth > health.health) 
		{
			health.curHealth = health.health;
		}
		
		HpBarLength = (Screen.width / 4) * (health.curHealth / (float)health.health);
	}
}