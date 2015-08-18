using UnityEngine;
using System.Collections;

public class GCScene4 : GameController {

	void Awake() {
		nextSceneString = "Pizza-Scene1";
	}

	// Update is called once per frame
	void Start () {
	
	}

	public void OnPizzaClick(GameObject bar) {
		SatisfactionController sc = bar.GetComponent<SatisfactionController> ();
		sc.transform.localScale += sc.growthRate;
		if (sc.transform.localScale.y >= 76) {
			this.NextScene();
		}
	}

}
