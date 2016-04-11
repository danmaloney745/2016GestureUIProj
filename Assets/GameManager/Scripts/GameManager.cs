using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager gm;
    public Transform player;
    public Transform spawnPoint;
    public float spawnDelay = 2f;
    //public Transform spawnParticle;
	public static bool gameOver = false;

    public GUIText GameOverText;
    public GUIText FinalScoreText;
    public GUIText ReplayText;
    public GUIText MainMenuText;
    public GUIText HighScoreText;

    private Score score;

    public GameObject menuCube;
    public GameObject restartCube;


    void Awake()
    {
        
        if (gm == null)
        {
            gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
        }

        score = GameObject.Find("Score").GetComponent<Score>();

        Initialize();
    }

    void Update()
    {
        if (gameOver == true)
        {
            GameOverText.text = "GAME OVER";            //Show GUI GameOver
            FinalScoreText.text = "FINAL SCORE: " + score.score;           //Show GUI FinalScore
            ReplayText.text = "Shoot the left box to replay!";      //Show GUI Replay
            MainMenuText.text = "Shoot the right box for main menu!";

            menuCube.SetActive(true);
            menuCube.GetComponent<Renderer>().enabled = true;

            restartCube.SetActive(true);
            restartCube.GetComponent<Renderer>().enabled = true;



            if (Input.GetKeyDown(KeyCode.R))
            {
				Destroy (GameObject.FindWithTag("Myo"));
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                //SceneManager.LoadScene("Box On A Stick");
                //Application.Quit();
                Application.LoadLevel(Application.loadedLevel);

            }

            if (Input.GetKeyDown(KeyCode.M))
            {
                Application.LoadLevel(Application.loadedLevel - 1);
            }

        }
    }

    private void Initialize()
    {
        //reset game values on intialisation
		gameOver = false;
        GameOverText.text = "";
        FinalScoreText.text = "";           
        ReplayText.text = "";
        MainMenuText.text = "";
    }

    public static void KillPlayer(Player player)
    {
        Destroy(player.gameObject);
    }

    public static void KillEnemy(Enemy enemy)
    {
        Destroy(enemy.gameObject);
    }

}
