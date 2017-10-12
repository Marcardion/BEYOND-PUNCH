using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsController : MonoBehaviour {

	public GameObject card1;
	public GameObject card2;
	public GameObject card3;
	public Camera camera;

	private bool slot1 = false;
	private bool slot2 = false;
	private bool slot3 = false;



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
					
					} else if (slot2 == false) {
					
						slot2 = true;
						card1.GetComponent<Animator> ().SetBool ("p1C1Slot2", true);
					
					} else {

						slot3 = true;
						card1.GetComponent<Animator> ().SetBool ("p1C1Slot3", true);

					}

				}


				if (hit.transform.gameObject == card2) {

					if (slot1 == false) {

						slot1 = true;
						card2.GetComponent<Animator> ().SetBool ("p1C2Slot1", true);

					} else if (slot2 == false) {

						slot2 = true;
						card2.GetComponent<Animator> ().SetBool ("p1C2Slot2", true);

					} else {

						slot3 = true;
						card2.GetComponent<Animator> ().SetBool ("p1C2Slot3", true);

					}

				}

				if (hit.transform.gameObject == card3) {

					if (slot1 == false) {

						slot1 = true;
						card3.GetComponent<Animator> ().SetBool ("p1C3Slot1", true);

					} else if (slot2 == false) {

						slot2 = true;
						card3.GetComponent<Animator> ().SetBool ("p1C3Slot2", true);

					} else {

						slot3 = true;
						card3.GetComponent<Animator> ().SetBool ("p1C3Slot3", true);

					}

				}


           // the object identified by hit.transform was clicked
           // do whatever you want
         }
       }
     }



}
