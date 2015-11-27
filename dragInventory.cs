using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dragInventory : MonoBehaviour {

	Vector3 startPosition;

	// Use this for initialization
	void Start () {
		startPosition = transform.position; //stores the start position of the inventory to then return back to it
	}

	//triggered when we drag an inventory object
	public void mouseDrag() {
		transform.position = Input.mousePosition;
	}

	//triggered when we stop dragging
	public void backToOriginal() {
		transform.position = startPosition;
	}
}
