using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsController : MonoBehaviour {

	public GameObject card1;
	public GameObject card2;
	public GameObject card3;
	public Camera camera;

	public string p1slot1Choose = "";
	public string p1slot2Choose = "";
	public string p1slot3Choose = "";

	public string p2slot1Choose = "grab";
	public string p2slot2Choose = "block";
	public string p2slot3Choose = "punch";



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

						p1slot1Choose = "block";
					
					} else if (slot2 == false) {
					
						slot2 = true;
						card1.GetComponent<Animator> ().SetBool ("p1C1Slot2", true);

						p1slot2Choose = "block";

					
					} else {

						slot3 = true;
						card1.GetComponent<Animator> ().SetBool ("p1C1Slot3", true);

						p1slot3Choose = "block";

					}

				}


				if (hit.transform.gameObject == card2) {

					if (slot1 == false) {

						slot1 = true;
						card2.GetComponent<Animator> ().SetBool ("p1C2Slot1", true);

						p1slot1Choose = "grab";


					} else if (slot2 == false) {

						slot2 = true;
						card2.GetComponent<Animator> ().SetBool ("p1C2Slot2", true);

						p1slot2Choose = "grab";


					} else {

						slot3 = true;
						card2.GetComponent<Animator> ().SetBool ("p1C2Slot3", true);

						p1slot3Choose = "grab";

					}

				}

				if (hit.transform.gameObject == card3) {

					if (slot1 == false) {

						slot1 = true;
						card3.GetComponent<Animator> ().SetBool ("p1C3Slot1", true);

						p1slot1Choose = "punch";

					} else if (slot2 == false) {

						slot2 = true;
						card3.GetComponent<Animator> ().SetBool ("p1C3Slot2", true);

						p1slot2Choose = "punch";

					} else {

						slot3 = true;
						card3.GetComponent<Animator> ().SetBool ("p1C3Slot3", true);

						p1slot3Choose = "punch";

					}

				}


           // the object identified by hit.transform was clicked
           // do whatever you want
         }
       }
     }



}
