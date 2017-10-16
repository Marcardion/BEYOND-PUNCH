using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CardsController : NetworkBehaviour {


	public GameObject card1;
	public GameObject card2;
	public GameObject card3;
	public Camera camera;

	private bool slot1 = false;
	private bool slot2 = false;
	private bool slot3 = false;

	[SyncVar]
	public string p1slot1Choose = "";
	[SyncVar]
	public string p1slot2Choose = "";
	[SyncVar]
	public string p1slot3Choose = "";
	[SyncVar]
	public string p2slot1Choose = "";
	[SyncVar]
	public string p2slot2Choose = "";
	[SyncVar]
	public string p2slot3Choose = "";





	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
     void Update(){
       if (Input.GetMouseButtonDown(0)){ // if left button pressed...
         Ray ray = camera.ScreenPointToRay(Input.mousePosition);
         RaycastHit hit;
         if (Physics.Raycast(ray, out hit)){

				if (hit.transform.gameObject == card1) {

					if (slot1 == false) {

						slot1 = true;					
						card1.GetComponent<Animator> ().SetBool ("p1C1Slot1", true);

						if (isServer) {
							Debug.Log ("tá no server");
							p1slot1Choose = "block";

						} else {
							Debug.Log ("não tá no server");
							p2slot1Choose = "block";
						}


					} else if (slot2 == false) {
					
						slot2 = true;
						card1.GetComponent<Animator> ().SetBool ("p1C1Slot2", true);

						if (isServer) {
						
							p1slot2Choose = "block";
						} else {
							p2slot2Choose = "block";
						}

					
					} else {

						slot3 = true;
						card1.GetComponent<Animator> ().SetBool ("p1C1Slot3", true);

						if (isServer) {
							p1slot3Choose = "block";
						} else {
							p2slot3Choose = "block";
						}

					}

				}


				if (hit.transform.gameObject == card2) {

					if (slot1 == false) {

						slot1 = true;
						card2.GetComponent<Animator> ().SetBool ("p1C2Slot1", true);

						if (isServer) {
							p1slot1Choose = "grab";
						
						} else {
							p2slot1Choose = "grab";
						}


					} else if (slot2 == false) {

						slot2 = true;
						card2.GetComponent<Animator> ().SetBool ("p1C2Slot2", true);

						if (isServer) {
							p1slot2Choose = "grab";
						} else {
							p2slot2Choose = "grab";
						}


					} else {

						slot3 = true;
						card2.GetComponent<Animator> ().SetBool ("p1C2Slot3", true);

						if (isServer) {
							p1slot3Choose = "grab";
						} else {
							p2slot3Choose = "grab";
						}

					}

				}

				if (hit.transform.gameObject == card3) {

					if (slot1 == false) {

						slot1 = true;
						card3.GetComponent<Animator> ().SetBool ("p1C3Slot1", true);

						if (isServer) {
							p1slot1Choose = "punch";
						} else {
							p2slot1Choose = "punch";
						}

					} else if (slot2 == false) {

						slot2 = true;
						card3.GetComponent<Animator> ().SetBool ("p1C3Slot2", true);

						if (isServer) {
							p1slot2Choose = "punch";
						} else {
							p2slot2Choose = "punch";
						}

					} else {

						slot3 = true;
						card3.GetComponent<Animator> ().SetBool ("p1C3Slot3", true);

						if (isServer) {
							p1slot3Choose = "punch";
						} else {
							p2slot3Choose = "punch";
						}

					}

				}


           // the object identified by hit.transform was clicked
           // do whatever you want
         }
       }
     }



}
