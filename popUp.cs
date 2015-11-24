using UnityEngine;
using System.Collections;

public class popUp : MonoBehaviour {

	public TextMesh textMesh;
	string[] textAndObject;
	public move playerMoveScript;
	
	// Use this for initialization
	public void popUpClick(string message) {
		textAndObject = message.Split ('|');
		textMesh.text = textAndObject[0];
		textMesh.gameObject.transform.position = GameObject.Find (textAndObject[1]).transform.position;
	}
}
