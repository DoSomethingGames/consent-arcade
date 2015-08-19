using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PizzaTopping : MonoBehaviour {

	public Sprite[] onPizzaAssets;

	// Use this for initialization
	void Start () {
		this.gameObject.SetActive(false);
	}
	
	public Sprite GetOnPizzaAsset(Ingredient.INGREDIENT_TYPE ingredient) {
		switch (ingredient) {
		case Ingredient.INGREDIENT_TYPE.ANCHOVIES:
			return onPizzaAssets[0];
		case Ingredient.INGREDIENT_TYPE.BACON:
			return onPizzaAssets[1];
		case Ingredient.INGREDIENT_TYPE.EXTRA_CHEESE:
			return onPizzaAssets[2];
		case Ingredient.INGREDIENT_TYPE.MUSHROOM:
			return onPizzaAssets[3];
		case Ingredient.INGREDIENT_TYPE.OLIVES:
			return onPizzaAssets[4];
		case Ingredient.INGREDIENT_TYPE.PEPPER:
			return onPizzaAssets[5];
		case Ingredient.INGREDIENT_TYPE.PEPPERONI:
			return onPizzaAssets[6];
		case Ingredient.INGREDIENT_TYPE.PINEAPPLE:
			return onPizzaAssets[7];
		default:
			Debug.Log("Could not find a matching ingredient type--onPizzaAsset not found");
			return null;
		}
	}

	public void SetImage(Ingredient.INGREDIENT_TYPE type) {
		Image choiceImage = this.GetComponent<Image>();
		choiceImage.sprite = this.GetOnPizzaAsset(type);
		this.gameObject.SetActive(true);
	}
}
