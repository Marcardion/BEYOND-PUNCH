using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFX : MonoBehaviour {

	public GameObject hit;
	public GameObject parry;
	public GameObject hold;
	public CardsController cardController;





	public  void Punch(){

		if (cardController.p1slot1Choose == "punch" && cardController.p2slot1Choose == "punch" || 
			cardController.p1slot2Choose == "punch" && cardController.p2slot2Choose == "punch" ||
			cardController.p1slot3Choose == "punch" && cardController.p2slot3Choose == "punch" 
		) {
			
			hit.SetActive (false);
			hit.SetActive (true);

		} else if(cardController.p1slot1Choose == "punch" && cardController.p2slot1Choose == "grab" ||
				  cardController.p1slot2Choose == "punch" && cardController.p2slot2Choose == "grab" ||
			      cardController.p1slot3Choose == "punch" && cardController.p2slot3Choose == "grab" 
		){
			hit.SetActive (false);
			hit.SetActive (true);

		} else if(cardController.p1slot1Choose == "punch" && cardController.p2slot1Choose == "block" ||
				  cardController.p1slot2Choose == "punch" && cardController.p2slot2Choose == "block" ||
				  cardController.p1slot3Choose == "punch" && cardController.p2slot3Choose == "block"
		
		){
			parry.SetActive (false);
			parry.SetActive (true);

		}
			

			
	}


	public void DisablePunch(){

		DisableAll ();
	
	}


	public  void Block(){
		

		if (cardController.p1slot1Choose == "block" && cardController.p2slot1Choose == "punch" ||
			cardController.p1slot2Choose == "block" && cardController.p2slot2Choose == "punch" ||
			cardController.p1slot3Choose == "block" && cardController.p2slot3Choose == "punch"
		
		) {
			
			parry.SetActive (false);
			parry.SetActive (true);

		} else if(cardController.p1slot1Choose == "block" && cardController.p2slot1Choose == "grab" ||
				  cardController.p1slot2Choose == "block" && cardController.p2slot2Choose == "grab" ||
				  cardController.p1slot3Choose == "block" && cardController.p2slot3Choose == "grab"
		
		){
			hold.SetActive (false);
			hold.SetActive (true);

		} else if(cardController.p1slot1Choose == "block" && cardController.p2slot1Choose == "block" ||
			      cardController.p1slot2Choose == "block" && cardController.p2slot2Choose == "block" ||
			      cardController.p1slot3Choose == "block" && cardController.p2slot3Choose == "block"
		){
			
			hold.SetActive (false);
			hold.SetActive (true);

		}

	}


	public void DisableBlock(){

		DisableAll ();
	}


	public  void Grab(){
		 
		if (cardController.p1slot1Choose == "grab" && cardController.p2slot1Choose == "punch" ||
			cardController.p1slot2Choose == "grab" && cardController.p2slot2Choose == "punch" ||
			cardController.p1slot3Choose == "grab" && cardController.p2slot3Choose == "punch"
		) {
			hit.SetActive (false);
			hit.SetActive (true);

			Debug.Log ("hit");

		} else if(cardController.p1slot1Choose == "grab" && cardController.p2slot1Choose == "grab" ||
				  cardController.p1slot2Choose == "grab" && cardController.p2slot2Choose == "grab" ||
			      cardController.p1slot3Choose == "grab" && cardController.p2slot3Choose == "grab"
		
		){
			hold.SetActive (false);
			hold.SetActive (true);

		} else if(cardController.p1slot1Choose == "grab" && cardController.p2slot1Choose == "block" ||
				  cardController.p1slot2Choose == "grab" && cardController.p2slot2Choose == "block" ||
				  cardController.p1slot3Choose == "grab" && cardController.p2slot3Choose == "block"
		){

			hold.SetActive (false);
			hold.SetActive (true);

		}

	}


	public void DisableGrab(){

		DisableAll ();
	}

	void DisableAll(){

		hold.SetActive (false);
		parry.SetActive (false);
		hit.SetActive (false);
	}

}
