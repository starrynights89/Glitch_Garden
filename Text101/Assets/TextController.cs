using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, cake, knife_0, manga_0, cell_cake, knife_1, manga_1, freedom};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
        text = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.cell) { State_cell(); }
		else if (myState == States.knife_0) 	{ State_knife_0(); }
		else if (myState == States.manga_0) 	{ State_manga_0(); }
		else if (myState == States.cake) 		{ State_cake(); }
		else if (myState == States.cell_cake) 	{ State_cell_cake(); }
		else if (myState == States.knife_1) 	{ State_knife_1(); }
		else if (myState == States.manga_1) 	{ State_manga_1(); }
		else if (myState == States.freedom) 	{ State_freedom(); }
	}

	void State_cell () {
		text.text = "You find yourself in Prison for crimes against the state " +
					"Your prison sentence is effective for the next ten billion years" +
					"with no parole.\n\n" + 
					"You sit down in a corner and wonder if it was worth pushing " +
					"your cis white male privilege on r/dankmemes. Anyways, you see " +
					"a knife, a pile of manga, and an odd smelling cake under your bed. " +
					"What do you do?\n\n " + "Press K to look at knife, " + 
					"press M to look at manga, press C to look at cake";
		if (Input.GetKeyDown(KeyCode.K)) 		{ myState = States.knife_0;}
		else if (Input.GetKeyDown(KeyCode.M)) 	{ myState = States.manga_0; }
		else if (Input.GetKeyDown(KeyCode.C))	{ myState = States.cake; }
	}

	void State_knife_0 () {
		text.text = "You go to observe the knife. 'Wait, why would there be a knife in " +
					"a prison cell?' You think to yourself before zoning out. You check " +
					"the knife again and you notice it's just a plastic knife from lunch. " +
					"It smells of discentary and an old newspaper. You take it with you.\n\n " +
					"Press R to return to your cell" ;
		if (Input.GetKeyDown(KeyCode.R)) 		{ myState = States.cell; }
	}

	void State_manga_0 () {
		text.text = "You find a pile of manga laying on your bed. It was the only thing " + 
					"you could bring with you besides the clothes that shame your degeneracy. " +
					"The manga is a collection of Berserk and trap series. You stuff them in a " +
					"bag for later.\n\n " + "Press R to return to your cell";
		if (Input.GetKeyDown(KeyCode.R)) 		{ myState = States.cell; }
	}
	void State_cake () {
		text.text = "You go to look at the cake which smells like swedish fish. You notice " +
					"in the cake a strange object shaped like an Ikea toolset. You take the " + 
					"toolset with you.\n\n " + "Press R to return to cell";
		if (Input.GetKeyDown(KeyCode.R)) 		{ myState = States.cell_cake; }
	}

	void State_cell_cake() {
		text.text = "You're back in the cell with the knife, pile of manga, and Ikea toolset. " + 
					"You notice a guard by the cell and decide to try to offer him one of " +
					"your items.\n\n" + "Press R to use knife, press M to use manga, press " +
					"T to use Ikea Toolest. ";
		if (Input.GetKeyDown(KeyCode.R)) 		{ myState = States.knife_1; }
		else if (Input.GetKeyDown(KeyCode.M)) 	{ myState = States.manga_1; }
		else if (Input.GetKeyDown(KeyCode.T)) 	{ myState = States.freedom; }
	}

	void State_knife_1() {
		text.text = ""
		if (Input.GetKeyDown(KeyCode.R)) 		{ myState = States.cell_cake; }
	}

	void State_manga_1() {

	}

	void State_freedom() {
		
	}
}
