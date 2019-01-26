using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{

	public static MainManager Instance;

	int lives;
	public int MAX_LIVES_COUNT;

	public enum States {
		STARTUP, IDLE, WIN_MINIGAME, LOSE_MINIGAME, WIN_GAME, GAME_OVER
	}

	public States states;

    // Start is called before the first frame update
    void Start()
    {
		Instance = this;
		states = States.STARTUP;
    }

    // Update is called once per frame
    void Update()
    {

    }

	public int get_lives() {
		return lives;
	}

}
