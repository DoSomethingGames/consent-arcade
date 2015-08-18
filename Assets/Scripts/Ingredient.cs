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
		OLIVES,
		PEPPERONI,
		PINEAPPLE
	};

	public INGREDIENT_TYPE type;
	public Text text;

	public Sprite[] assets;
	public string[] names;
	
	public const int LENGTH = 8;

	public Sprite GetAsset(INGREDIENT_TYPE ingredient) {
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

	public void SetType(INGREDIENT_TYPE other) {
		this.type = other;
	}

	public INGREDIENT_TYPE GetType() {
		return this.type;
	}

	public void Disable() {
		this.GetComponent<Button>().interactable = false;
	}

	public static INGREDIENT_TYPE GetRandomType() {
		INGREDIENT_TYPE ingredientType = (INGREDIENT_TYPE)Random.Range(0, LENGTH);
		return ingredientType;
	}
}
