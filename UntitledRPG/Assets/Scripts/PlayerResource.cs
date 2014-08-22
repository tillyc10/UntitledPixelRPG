using UnityEngine;
using System.Collections;

public class PlayerResource : MonoBehaviour 
{
	public int maxResource = 100;
	public int curResource = 100;
	public float HpBarLength;
	// Use this for initialization
	void Start () 
	{
		HpBarLength = Screen.width / 4;
	}
	
	// Update is called once per frame
	void Update () 
	{
		AdjustCurrentResource (0);
	}
	void OnGUI()
	{
		GUI.Box (new Rect(10,(Screen.height/19)*18,HpBarLength, 20), "HP: " + curResource + "/" + maxResource);
	}
	public void AdjustCurrentResource(int adj)
	{
		curResource += adj;
		
		if (curResource < 0) 
		{
			curResource = 0;
		}
		if (curResource > maxResource) 
		{
			curResource = maxResource;
		}
		
		HpBarLength = (Screen.width / 4) * (curResource / (float)maxResource);
	}
}