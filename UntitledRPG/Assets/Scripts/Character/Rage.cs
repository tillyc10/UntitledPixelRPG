using UnityEngine;
using System.Collections;

public class Rage : MonoBehaviour 
{
	public float BarLength;
	// Use this for initialization
	void Start () 
	{
		BarLength = Screen.width / 4;
	}
	
	// Update is called once per frame
	void Update () 
	{
		AdjustCurrentRage (0);
	}
	void OnGUI()
	{
		Berserker rage = GetComponent<Berserker>();
		GUI.Box (new Rect(10,(Screen.height/19)*18,BarLength, 20), "Rage: " + rage.curRage + "/" + rage.rage);
	}
	public void AdjustCurrentRage(int adj)
	{
		Berserker rage = GetComponent<Berserker>();
		rage.curRage += adj;
		
		if (rage.curRage < 0) 
		{
			rage.curRage = 0;
		}
		if (rage.curRage > rage.rage) 
		{
			rage.curRage = rage.rage;
		}
		
		BarLength = (Screen.width / 4) * (rage.curRage / (float)rage.rage);
	}
}