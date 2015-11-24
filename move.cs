using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public float speed = 5f;

	Vector3 mousePosOnlyX;
	Vector3 mousePos;
	private float startTime;
	private float journeyLength;
	private bool moving = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp (0)) {
			mousePos = Input.mousePosition;
			mousePos.z = 10.0f;
			mousePos = Camera.main.ScreenToWorldPoint(mousePos);

			mousePosOnlyX = new Vector3(mousePos.x, transform.position.y, mousePos.z);

			startTime = Time.time;
			journeyLength = Vector3.Distance(transform.position, mousePosOnlyX);

			moving = true;
		}

		if (moving) {
			float distCovered = (Time.time - startTime) * speed;
			float fracJourney = distCovered / journeyLength;
			transform.position = Vector3.Lerp (transform.position, mousePosOnlyX, fracJourney); //speed*Time.deltaTime
		}
	}
}
