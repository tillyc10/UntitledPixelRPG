using UnityEngine;
using System.Collections;

public class CombatHUD : MonoBehaviour {

	public int maxHealth;
	public int curHealth;
	public float HpBarLength; 


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnGUI() {
		GUI.Box (new Rect(800,(Screen.height/10)*7,HpBarLength, 20), "HP: " + curHealth + "/" + maxHealth);

		if (GUI.Button (new Rect (25, 400, 700, 50), "Attack 1")) {
				}
		if (GUI.Button (new Rect (25, 455, 700, 50), "Attack 2")) {
				}
		if (GUI.Button (new Rect (25, 510, 700, 50), "Attack 3")) {
				}
		if (GUI.Button (new Rect (25, 565, 700, 50), "Attack 4")) {
				}
	}
}
