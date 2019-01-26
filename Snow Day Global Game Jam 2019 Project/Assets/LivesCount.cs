using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesCount : MonoBehaviour
{

	public Spoon spoon;

	int current_lives;
	int current_max_lives;

	public List<Spoon> spoons = new List<Spoon>(); 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MainManager.Instance == null)
			return;

		SyncLives();
    }

	void SyncLives() {
		if (current_lives != MainManager.Instance.get_lives()) {
			//TODO: Foreach spoon in spoon if spoon is more than the current lives. Destroy the spoon in style)
		}
	}
}
