using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    LevelManager levelManager = new LevelManager();

    public int maxHits;

    int timesHit;

	// Use this for initialization
	void Start () {

        timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.tag == "Breakable")
        {
            timesHit++;
            print(this.name + " : " + timesHit);

            if (timesHit >= maxHits)
            {
                TestWin();
                Destroy(gameObject);
            }
        }
    } 

    public void TestWin()
    {
        levelManager.LoadNextScene();
    }

}
