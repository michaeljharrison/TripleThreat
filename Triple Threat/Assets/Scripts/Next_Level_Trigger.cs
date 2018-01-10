using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_Level_Trigger : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	// Triggers when ANY collider enters the trigger.
	void OnTriggerEnter (Collider colliderHit) {
		// Check if it's the player that collided:
		string objectHit = colliderHit.gameObject.tag;
		Debug.Log (objectHit);

		// Loads the next scene async.
		StartCoroutine (LoadNextScene ());
	}

	IEnumerator LoadNextScene () {
		AsyncOperation loadNextScene = SceneManager.LoadSceneAsync ("Scene_2");

		// This just waits for load to finish before exiting first scene.
		while (!loadNextScene.isDone) {
			yield return null;
		}
	}
}