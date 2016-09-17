using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {

	public enum States {Play,Dead,Win};

	public States state;
	public static bool move;

	// Use this for initialization
	void Start () {
		state = States.Play;
	}
	
	// Update is called once per frame
	void Update () {
		print (state);
		StateMachine ();
		if (state.Equals (States.Dead)) {
			print ("you dead");
		}
	}


	void StateMachine(){
		MoveDisable ();
		if (PlayerMove.health <= 0) {
			state = States.Dead;
		}
	}

	void MoveDisable(){
		switch (state) {
		case States.Play:
			move = true;
			break;
		case States.Dead:
			move = false;
			break;
		}
	}
}
	
	
