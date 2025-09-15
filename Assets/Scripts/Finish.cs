using Unity.VisualScripting;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject MovingPlayer;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private AudioSource FinishSound;
    private void OnTriggerEnter()
    {
        FinishSound.Play();
        MovingPlayer.GetComponent<MovingPlayer>().enabled = false;
        gameManager.WinGame();
    }
}
