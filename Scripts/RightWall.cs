using Unity.VisualScripting;
using UnityEngine;

public class RightWall : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private GameObject MovingPlayer;
    [SerializeField] private AudioSource FallSound;
    private void OnTriggerEnter()
    {
        FallSound.Play();
        gameManager.GameOver();
        MovingPlayer.GetComponent<Rigidbody>().AddForce(new Vector3(500*Time.deltaTime,-1000*Time.deltaTime,370*Time.deltaTime), ForceMode.Impulse);
    }
}
