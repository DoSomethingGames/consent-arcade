using UnityEngine;
using System.Collections;

public class GCScene3 : GameController {

	void Awake () {
		nextSceneString = "Pizza-Scene4";
	}

	protected void Start () {
		base.Start ();
	}

	// Update is called once per frame
	void Update () {
	
	}

	/**
	 * Function called when an ingredient is clicked.
	 * 
	 * @param Object ingredient
	 *   The Ingredient selected on click
	 */
	public void OnIngredientClick (GameObject ingredient) {
		
		Ingredient selected = ingredient.GetComponent<Ingredient> ();
		Data.AddFinalChoice (selected);

		selected.Disable ();
		
		if (Data.curFinalNum == 3) {
			this.NextScene ();
		}
	}
}