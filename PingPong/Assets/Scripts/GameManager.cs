using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    private int _playerScore;
    private int _computerScore;
    public Text playerScoreText;
    public Text computerScoreText;
    public Puddle playerPuddle;
    public Puddle computerPuddle;

    public void PlayerScores()
    {
        _playerScore++;
        
        playerScoreText.text = _playerScore.ToString();
        ResetRound();
    }
    public void ComputerScores()
    {
        _computerScore++;
        computerScoreText.text = _computerScore.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        ball.ResetPosition();
        ball.AddStartingForce();
        playerPuddle.ResetPosition();
        computerPuddle.ResetPosition();
    }

}
