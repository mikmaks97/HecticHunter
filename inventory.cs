using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class inventory : MonoBehaviour {

	public List<Sprite> inventoryObjects; //a list of inventory objects
	public Image inventoryPic;
	public static int currentInventoryIndex;

	// Use this for initialization
	void Start () {
		List<GameObject> inventoryObjects = new List<GameObject> ();
		currentInventoryIndex = -1; //we start our list with no objects
	}
	
	// Update is called once per frame
	void Update () {
		//if an object appears in the list, turn the inventory on and display that object
		if (currentInventoryIndex >= 0) {
			inventoryPic.enabled = true;
			inventoryPic.sprite = inventoryObjects [currentInventoryIndex];
		}
		else //otherwise hide the inventory
			inventoryPic.enabled = false;

		//if we scroll up
		if (Input.GetAxis ("Mouse ScrollWheel") > 0f) {
			currentInventoryIndex++;
			if (currentInventoryIndex >= inventoryObjects.Count)
				currentInventoryIndex = 0;
		} 
		//if we scroll down
		else if (Input.GetAxis ("Mouse ScrollWheel") < 0f) {
			currentInventoryIndex--;
			if (currentInventoryIndex < 0)
				currentInventoryIndex = inventoryObjects.Count-1;
		}
	}
}
