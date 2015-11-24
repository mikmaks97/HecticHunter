using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	//player's moving speed
	public float speed = 5f;

	//mouse position variables
	Vector3 mousePosOnlyX; //we need it to move only horizontally
	Vector3 mousePos;

	private float startTime;
	private float journeyLength;
	private bool moving = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if the left mouse button is pressed...
		if (Input.GetMouseButtonUp (0)) {
			mousePos = Input.mousePosition; //get the mouse position
			mousePos.z = 10.0f; //set the z-distance
			mousePos = Camera.main.ScreenToWorldPoint(mousePos); //convert pixels to Unity world units

			//take only the x and z positions from the mouse
			mousePosOnlyX = new Vector3(mousePos.x, transform.position.y, mousePos.z);

			//this is for smooth movement
			startTime = Time.time;
			journeyLength = Vector3.Distance(transform.position, mousePosOnlyX);

			//we're moving!
			moving = true;
		}

		//if the player is moving...
		if (moving) {
			float distCovered = (Time.time - startTime) * speed;
			float fracJourney = distCovered / journeyLength;
			//Lerp means to smoothly transition. so we are smoothly transitioning from the player's current position to the mouse position in 'fracJourney' amount of time
			transform.position = Vector3.Lerp (transform.position, mousePosOnlyX, fracJourney); //speed*Time.deltaTime
		}
	}
}
