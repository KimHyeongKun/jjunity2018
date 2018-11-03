using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    IDLE = 0,
    RUN,
    CHASE,
    ATTACK 
}

public class FSMManager : MonoBehaviour {

    public PlayerState currentState;
    public PlayerState startState;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
