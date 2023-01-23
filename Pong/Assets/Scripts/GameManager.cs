using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Paddle playerPaddle;

    public Paddle computerPaddle;

    public Ball ball;

    public Text playerScoreText;

    public Text computerScoreText;

    private int playerScore;

    private int computerScore;

    private void Awake()
    {
        Instance = this;
    }

    public void PlayerScores()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();

        ResetRound();
    }
    public void ComputerScores()
    {
        computerScore++;
        playerScoreText.text = computerScore.ToString();

        ResetRound();
    }

    private void ResetRound()
    {
        ball.ResetPosition();
        ball.AddStartingForce();
        playerPaddle.ResetPaddlePosition();
        computerPaddle.ResetPaddlePosition();
    }
}
