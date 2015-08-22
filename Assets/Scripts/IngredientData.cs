using UnityEngine;
using System.Collections;

public class IngredientData : MonoBehaviour {

	public enum INGREDIENT_TYPE {
		ANCHOVIES,
		BACON,
		EXTRA_CHEESE,
		MUSHROOM,
		PEPPER,
		OLIVES,
		PEPPERONI,
		PINEAPPLE
	};

	public static Sprite[] assets;
	public static string[] names;
	public static Sprite[] onPizzaAssets;
	
	public const int LENGTH = 8;

	public static Sprite GetAsset(INGREDIENT_TYPE ingredient) {
		switch (ingredient) {
		case INGREDIENT_TYPE.ANCHOVIES:
			return assets[0];
		case INGREDIENT_TYPE.BACON:
			return assets[1];
		case INGREDIENT_TYPE.EXTRA_CHEESE:
			return assets[2];
		case INGREDIENT_TYPE.MUSHROOM:
			return assets[3];
		case INGREDIENT_TYPE.OLIVES:
			return assets[4];
		case INGREDIENT_TYPE.PEPPER:
			return assets[5];
		case INGREDIENT_TYPE.PEPPERONI:
			return assets[6];
		case INGREDIENT_TYPE.PINEAPPLE:
			return assets[7];
		default:
			Debug.Log("Could not find a matching ingredient type--asset not found");
			return null;
		}
	}
	
	public static string GetText(INGREDIENT_TYPE ingredient) {
		switch (ingredient) {
		case INGREDIENT_TYPE.ANCHOVIES:
			return names[0];
		case INGREDIENT_TYPE.BACON:
			return names[1];
		case INGREDIENT_TYPE.EXTRA_CHEESE:
			return names[2];
		case INGREDIENT_TYPE.MUSHROOM:
			return names[3];
		case INGREDIENT_TYPE.OLIVES:
			return names[4];
		case INGREDIENT_TYPE.PEPPER:
			return names[5];
		case INGREDIENT_TYPE.PEPPERONI:
			return names[6];
		case INGREDIENT_TYPE.PINEAPPLE:
			return names[7];
		default:
			Debug.Log("Could not find a matching ingredient type--text not found");
			return null;
		}
	}

	public static Sprite GetOnPizzaAsset(INGREDIENT_TYPE ingredient) {
		switch (ingredient) {
		case INGREDIENT_TYPE.ANCHOVIES:
			return onPizzaAssets[0];
		case INGREDIENT_TYPE.BACON:
			return onPizzaAssets[1];
		case INGREDIENT_TYPE.EXTRA_CHEESE:
			return onPizzaAssets[2];
		case INGREDIENT_TYPE.MUSHROOM:
			return onPizzaAssets[3];
		case INGREDIENT_TYPE.OLIVES:
			return onPizzaAssets[4];
		case INGREDIENT_TYPE.PEPPER:
			return onPizzaAssets[5];
		case INGREDIENT_TYPE.PEPPERONI:
			return onPizzaAssets[6];
		case INGREDIENT_TYPE.PINEAPPLE:
			return onPizzaAssets[7];
		default:
			Debug.Log("Could not find a matching ingredient type--onPizzaAsset not found");
			return null;
		}
	}

	public static INGREDIENT_TYPE GetRandomType() {
		INGREDIENT_TYPE ingredientType = (INGREDIENT_TYPE)Random.Range(0, LENGTH);
		return ingredientType;
	}

}
