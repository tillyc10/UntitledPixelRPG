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


		if (GUI.Button (new Rect (350, 390, 700, 50), "Attack 1")) {
					print ("attack 1");
				}
		if (GUI.Button (new Rect (350, 445, 700, 50), "Attack 2")) {
					print ("attack 2");
				}
		if (GUI.Button (new Rect (350, 500, 700, 50), "Attack 3")) {
					print ("attack 3");
				}
		if (GUI.Button (new Rect (350, 555, 700, 50), "Attack 4")) {
					print ("attack 4");
				}
	}
}
