using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ScoreText;
    [SerializeField] private GameObject GameOverText;
    [SerializeField] private GameObject FinishWordText_1;
    [SerializeField] private GameObject FinishWordText_2;
    [SerializeField] private GameObject GameOverImage;
    [SerializeField] private GameObject WinGameImage;
    [SerializeField] private GameObject Player;

    private IEnumerator PrintGameOver()
    {
        GameOverText.SetActive(true);
        GameOverImage.SetActive(true);
        yield return null;
    }
    public void GameOver()
    {
        StartCoroutine("PrintGameOver");
        ScoreText.GetComponent<Score>().enabled = false;
        Player.GetComponent<Rigidbody>().freezeRotation = false;
        Player.GetComponent<MovingPlayer>().enabled = false;
        Invoke("Restart", 1.7f); //обращаю внимание, что Invoke обращается к методу по названию с помощью ""
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void WinGame()
    {
        FinishWordText_1.SetActive(true);
        FinishWordText_2.SetActive(true);
        WinGameImage.SetActive(true);
    }

}
