using UnityEngine;
using System.Collections;

public class PlayerGold : MonoBehaviour 
{
	public int goldAmount = 25;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnGUI()
	{
		GUI.Box (new Rect (10, 10, 60, 20), "Gold: " + goldAmount);
	}

	public void AdjustGoldAmount(int adj)
	{
		goldAmount += adj;
	}
}
