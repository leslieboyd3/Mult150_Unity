using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange;
    public ChaosGoalScript chaos;
    private bool isGameOver = true;

     // Flags that control the state of the game
    private float elapsedTime = 0;
    private bool isRunning = false;
    private bool isFinished = false;

      // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    //This resets to game back to the way it started
    private void StartGame()
    {
        elapsedTime = 0;
        isRunning = true;
        isFinished = false;
    }

    // Update is called once per frame
    void Update()
    {
        // If all four goals are solved then the game is over
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved && chaos.isSolved;
        // Add time to the clock if the game is running
        if (isRunning)
        {
            elapsedTime = elapsedTime + Time.deltaTime;
        }
    }

        // Runs when the player enters the finish zone
    public void FinishedGame()
    {
        isRunning = false;
        isFinished = true;
    }

    //This section creates the Graphical User Interface (GUI)
    void OnGUI()
    {
        if (isGameOver)
        {
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height /
            2 - 50, 200, 75);
            GUI.Box(rect, "Game Over");
            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height /
            2 - 25, 60, 50);
            GUI.Label(rect2, "Good Job!");
            FinishedGame();
        }

        // If the player finished the game, show the final time
        if (isFinished)
        {
            GUI.Box(new Rect(Screen.width / 2 - 65, 185, 130, 40), "Your Time Was");
            GUI.Label(new Rect(Screen.width / 2 - 10, 200, 20, 30), ((int)elapsedTime).ToString());
        }
    }
}
