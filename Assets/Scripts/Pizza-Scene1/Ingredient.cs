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

}
