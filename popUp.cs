using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class popUp : MonoBehaviour {
	
	public TextMesh textMesh;
	public Transform popUpLocation;
	public inventory inventoryScript;

	string[] textAndObject;

	//when an object is clicked that needs a popup...
	public void popUpClick(string message) {
		//we split the message up into two things: the actual text and the name of the object that was pressed
		textAndObject = message.Split ('|'); //we split using this character '|'
		textMesh.text = textAndObject[0];
		//the text mesh's position is equal to the position of the player :)
		textMesh.gameObject.transform.position = popUpLocation.transform.position;

		//store the sprite of the clicked-on object
		Sprite inventoryObject = GameObject.Find (textAndObject [1]).GetComponent<SpriteRenderer>().sprite;
		if (inventoryObject != null) { //if the sprite isn't null, i.e. we clicked on an object that should go in the inventory
			inventoryScript.inventoryObjects.Add (inventoryObject); //add it to the list of inventory objects
			inventory.currentInventoryIndex = inventoryScript.inventoryObjects.Count-1; //display it immediately
			GameObject.Find (textAndObject [1]).SetActive(false); //hide the actual object from the world
		}
	}
}
