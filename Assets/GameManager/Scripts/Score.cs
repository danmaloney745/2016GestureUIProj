using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    public int score = 0;
    public int currScore = 0;

    private string newScore = "Score";
    private string newTime = "Time";

    //private PlayerHealth player;
    //private int prevScore = 0;

    void Awake()
    {
        //player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<GUIText>().text = "Score: " + score;
 
        currScore = score;
        PlayerPrefs.SetInt(newScore, currScore);
        //Debug.Log("Current Score: " + currScore);

	}
}
