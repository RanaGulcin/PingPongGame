using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Paddle playerPaddle;
    public Paddle computerPaddle;

    public Text playerScoreText;
    public Text computerScoreText;

    private int _playerScore;
    private int _computerScore;

    public void PlayerScores()//oyuncu skoru ekleme
    {
        _playerScore++;

        this.playerScoreText.text = _playerScore.ToString();
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

    public void ComputerScores()//bilgisayar skoru ekleme
    {
        _computerScore++;

        this.computerScoreText.text = _computerScore.ToString();
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

}
