using UnityEngine;
using System.Collections;

public class popUp : MonoBehaviour {
	
	public TextMesh textMesh;
	string[] textAndObject;
	public move playerMoveScript;

	//when an object is clicked that needs a popup...
	public void popUpClick(string message) {
		//we split the message up into two things: the actual text and the name of the object that was pressed
		textAndObject = message.Split ('|'); //we split using this character '|'
		textMesh.text = textAndObject[0]; //the text goes into the text mesh
		//the text mesh's position is equal to the position of the object that we find by its name :)
		textMesh.gameObject.transform.position = GameObject.Find (textAndObject[1]).transform.position;
	}
}
