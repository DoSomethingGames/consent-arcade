using UnityEngine;
using System.Collections;

public class GCScene4 : GameController {

	void Awake() {
		nextSceneString = "Win-Scene";
//		if (!Data.CompareChoices ()) { //compares what happened in scene 3, janky solution
//			Debug.Log ("YA FAIL");
//			this.LoadFailScene();
//		}
		toFail = true;
	}

	// Update is called once per frame
//	void Start () {
//	
//	}

	public void OnPizzaClick(GameObject bar) {
		SatisfactionController sc = bar.GetComponent<SatisfactionController> ();
		sc.transform.localScale += sc.growthRate;
		if (sc.transform.localScale.y >= 70) {
			this.LoadNextScene();
		}
	}

}
