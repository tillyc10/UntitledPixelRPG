using UnityEngine;
using System.Collections;

public class PlayerResource : MonoBehaviour 
{
	public int maxResource;
	public int curResource;

	public float BarLength;
	// Use this for initialization
	void Start () 
	{
		BarLength = Screen.width / 4;
	}
	
	// Update is called once per frame
	void Update () 
	{
		AdjustCurrentResource (0);
	}
	void OnGUI()
	{
		GUI.Box (new Rect(10,(Screen.height/19)*18,BarLength, 20), curResource + "/" + maxResource);
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
		
		BarLength = (Screen.width / 4) * (curResource / (float)maxResource);
	}
}