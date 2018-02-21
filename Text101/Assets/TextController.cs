using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, manga, knife_0, cake_0, cell_manga, knife_1, cake_2, freedom};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.cell) {
			State_cell();
		} else if (myState == States.knife_0) {
			State_knife_0();
			}
		}

	void State_cell () {
		text.text = "You find yourself in Prison for committing the crime " +
					"of posting too many dank memes. Your prison sentence " +
					"is effective for the next ten billion years with no parole.\n\n" +
					"You sit down in a corner and wonder if it was worth pushing " +
					"your cis white male privilege on r/dankmemes. Anyways, you see " +
					"a knife, a pile of manga, and an odd smelling cake under your bed. " +
					"What do you do?\n\n " + "Press K to look at knife, " + 
					"press M to look at manga, press C to look at cake";
		if (Input.GetKeyDown(KeyCode.K)) {
			myState = States.knife_0;
		}
	}

	void State_knife_0 () {
		text.text = "You go to observe the knife. 'Wait, why would there be a knife in " +
					"a prison cell?' You think to yourself before zoning out. You check " +
					"the knife again and you notice it's just a plastic knife from lunch. " +
					"It smells of discentary and an old newspaper.\n\n " +
					"Press R to return to roaming your cell" ;
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		}
	}
}
