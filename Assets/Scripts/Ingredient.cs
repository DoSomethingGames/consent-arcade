using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Ingredient : MonoBehaviour {

	public enum INGREDIENT_TYPE {
		ANCHOVIES,
		BACON,
		EXTRA_CHEESE,
		MUSHROOM,
		PEPPER,
		PEPPERONI,
		PINEAPPLE,
		SAUSAGE
	};

	public INGREDIENT_TYPE type;
	public Text text;
	public Image image;

	public Image[] assets;
	public Image[] onPizzaAssets;
	public string[] names;
	
	public const int LENGTH = 8;
	
	public Image GetAsset(INGREDIENT_TYPE ingredient) {

		switch (ingredient) {
		case INGREDIENT_TYPE.ANCHOVIES:
			return assets[0];
		case INGREDIENT_TYPE.BACON:
			return assets[1];
		case INGREDIENT_TYPE.EXTRA_CHEESE:
			return assets[2];
		case INGREDIENT_TYPE.MUSHROOM:
			return assets[3];
		case INGREDIENT_TYPE.PEPPER:
			return assets[4];
		case INGREDIENT_TYPE.PEPPERONI:
			return assets[5];
		case INGREDIENT_TYPE.PINEAPPLE:
			return assets[6];
		case INGREDIENT_TYPE.SAUSAGE:
			return assets[7];
		default:
			Debug.Log("Could not find a matching ingredient type--asset not found");
			return null;
		}
	}

	public Image GetOnPizzaAsset(INGREDIENT_TYPE ingredient) {
		switch (ingredient) {
		case INGREDIENT_TYPE.ANCHOVIES:
			return onPizzaAssets[0];
		case INGREDIENT_TYPE.BACON:
			return onPizzaAssets[1];
		case INGREDIENT_TYPE.EXTRA_CHEESE:
			return onPizzaAssets[2];
		case INGREDIENT_TYPE.MUSHROOM:
			return onPizzaAssets[3];
		case INGREDIENT_TYPE.PEPPER:
			return onPizzaAssets[4];
		case INGREDIENT_TYPE.PEPPERONI:
			return onPizzaAssets[5];
		case INGREDIENT_TYPE.PINEAPPLE:
			return onPizzaAssets[6];
		case INGREDIENT_TYPE.SAUSAGE:
			return onPizzaAssets[7];
		default:
			Debug.Log("Could not find a matching ingredient type--onPizzaAsset not found");
			return null;
		}
	}

	public string GetText(INGREDIENT_TYPE ingredient) {
		
		switch (ingredient) {
		case INGREDIENT_TYPE.ANCHOVIES:
			return names[0];
		case INGREDIENT_TYPE.BACON:
			return names[1];
		case INGREDIENT_TYPE.EXTRA_CHEESE:
			return names[2];
		case INGREDIENT_TYPE.MUSHROOM:
			return names[3];
		case INGREDIENT_TYPE.PEPPER:
			return names[4];
		case INGREDIENT_TYPE.PEPPERONI:
			return names[5];
		case INGREDIENT_TYPE.PINEAPPLE:
			return names[6];
		case INGREDIENT_TYPE.SAUSAGE:
			return names[7];
		default:
			Debug.Log("Could not find a matching ingredient type--asset not found");
			return null;
		}
	}

	public void SetType(INGREDIENT_TYPE other) {
		this.type = other;
	}

	public INGREDIENT_TYPE GetType() {
		return this.type;
	}

	public static INGREDIENT_TYPE GetRandomType() {
		INGREDIENT_TYPE ingredientType = (INGREDIENT_TYPE)Random.Range(0, LENGTH);
		return ingredientType;
	}
}
