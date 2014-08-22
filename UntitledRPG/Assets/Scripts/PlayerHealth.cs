using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour 
{
	public int maxHealth = 100;
	public int curHealth = 100;

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
		GUI.Box (new Rect(10,(Screen.height/10)*9,HpBarLength, 20), "HP: " + curHealth + "/" + maxHealth);
	}
	public void AdjustCurrentHealth(int adj)
	{
		curHealth += adj;

		if (curHealth < 0) 
		{
			curHealth = 0;
		}
		if (curHealth > maxHealth) 
		{
			curHealth = maxHealth;
		}

		HpBarLength = (Screen.width / 4) * (curHealth / (float)maxHealth);
	}
}