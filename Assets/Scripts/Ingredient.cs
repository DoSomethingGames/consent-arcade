using UnityEngine;
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

	public GameObject[] assets;
	
	public const int LENGTH = 8;
	
	public GameObject getAsset(INGREDIENT_TYPE ingredient) {

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
}
