using UnityEngine;
using System.Collections;

public class GCScene3 : GameController {

	public PizzaTopping[] toppings;
	public int curToppingNum;

	void Awake () {
		nextSceneString = "Pizza-Scene4";
		curToppingNum = 0;
	}

	protected void Start () {
		base.Start ();
	}

	// Update is called once per frame
	void Update () {}

	/**
	 * Function called when an ingredient is clicked.
	 * 
	 * @param Object ingredient
	 *   The Ingredient selected on click
	 */
	public void OnIngredientClick (GameObject ingredient) {
		
		Ingredient selected = ingredient.GetComponent<Ingredient> ();
		Data.AddFinalChoice (selected);

		toppings[curToppingNum].SetImage(selected.GetType());

		curToppingNum++;
		selected.Disable ();
		
		if (Data.curFinalNum == 3) {
			this.NextScene ();
		}
	}
}