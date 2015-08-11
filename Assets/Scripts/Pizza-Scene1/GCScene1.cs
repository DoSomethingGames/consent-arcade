using UnityEngine;
using System.Collections;

public class GCScene1 : GameController {
	
	private int numSelected = 0;

	public Ingredient[] choices;

	// Update is called once per frame
	void Update () {}
	
	/**
	 * Function called when an ingredient is clicked.
	 * 
	 * @param Object ingredient
	 *   The Ingredient selected on click
	 */
	public void OnIngredientClick (GameObject ingredient) {
		
		Ingredient selected = ingredient.GetComponent<Ingredient>();
		
		selected.transform.position = choices[numSelected].transform.position;
		numSelected++;

		if (numSelected == 3) {
			this.SetPlayerChoices(choices);
			this.EndScene ();
		}
	}

	private void SetPlayerChoices(Ingredient[] choices) {
		if (choices.Length != playerChoices.Length) {
			return;
		}
	}
}
