using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Ingredient : MonoBehaviour {

	public IngredientData.INGREDIENT_TYPE type;
	public Text text;

	public void SetType(IngredientData.INGREDIENT_TYPE other) {
		this.type = other;
	}

	public IngredientData.INGREDIENT_TYPE GetType() {
		return this.type;
	}

	public void Disable() {
		this.GetComponent<Button>().interactable = false;
	}
}
