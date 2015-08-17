using UnityEngine;
using System.Collections;

public class GCScene4 : GameController {

	public CanCant result;

	void Start() {
		result.SetText (Data.CompareChoices());
	}

	// Update is called once per frame
	void Update () {
	
	}

	void CompareChoices() {
	}


}
