using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Animator awakeAnimation;
    public GameObject blackScreen;
    public GameObject table;

    int animationDelay = 40;
    int animationDelayTwo = 3;
    int dialogueWait = 3;
    int endGameOverWait = 15;
    int sceneTransition = 5;
    
    public bool hasItem1;
    public bool hasItem2;
    public bool hasItem3;
    public bool hasItem4;
    public bool bearTalk;
    public bool chickenTalk;
    public bool flowerTalk;
    public bool robotTalk;
    public bool alienTalk;
    public bool bigTalk;
    public bool fatTalk;
    public bool farmerTalk;
    public bool queenTalk;
    public int finalChatCount;
    public bool isControllable;

    private void Awake() 
    {
        //isControllable = true; //To be removed
        awakeAnimation.SetTrigger("Awake");
        Invoke("StartPlayer", animationDelay);
    }

    public void FixedUpdate() 
    {
        if (finalChatCount >= 9)
        {
            WaitGameOver();
        }
    }

    void StartPlayer ()
    {
        isControllable = true;
        blackScreen.SetActive(false);
    }

    public void WaitEndingDinner()
    {
        GameObject player = GameObject.Find("Player");
        player.GetComponent<PlayerManager>().GainStrength(20);

        table.SetActive(true);

        Invoke("EndingDinner", dialogueWait);
    }

    public void EndingDinner()
    {
        GameObject player = GameObject.Find("Player");
        isControllable = false;
        blackScreen.SetActive(true);

        player.transform.position = new Vector3 (-4.74f ,6.95f ,0);        
        
        awakeAnimation.SetTrigger("Dinner");
        //blackScreen.SetActive(true);
        Invoke("DinnerPlayer", animationDelayTwo);

    }

    void DinnerPlayer ()
    {
        isControllable = true;
        blackScreen.SetActive(false);
    }

    public void WaitGameOver ()
    {
        Invoke("GameOver", endGameOverWait);
    }

    void GameOver ()
    {
        GameObject player = GameObject.Find("Player");
        isControllable = false;
        blackScreen.SetActive(true);

        awakeAnimation.SetTrigger("Fin");
        Invoke("SceneChange", sceneTransition);
    }

    void SceneChange ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
