using UnityEngine;

public class MovingPlayer : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private AudioSource HitObstacleSound;
    [SerializeField] private AudioSource FallSound;
    [SerializeField] private Rigidbody Player;
    [SerializeField] private Transform PlayerTransform;


    [SerializeField] private float ForwardMovementSpeed;
    [SerializeField] private float HorizontalMovementSpeed;
    [SerializeField] private float JumpForce;
    private bool OnTheGround;
    private void OnCollisionEnter(Collision Object)
    {
        if (Object.gameObject.tag == "Platform")
        {
            OnTheGround = true;
        }
        if (Object.gameObject.tag == "Stairs")
        {
            OnTheGround = false;
        }
        if (Object.gameObject.tag == "Obstacle")
        {
            HitObstacleSound.Play();
            gameManager.GameOver();
        }
    }
    private void OnCollisionStay(Collision Object)
    {
        if (Object.gameObject.tag == "Stairs")
        {
            Player.AddForce(new Vector3(0, -2000 * Time.deltaTime, 9000 * Time.deltaTime));
        }
    }

    private void FixedUpdate()
    {
        Player.AddForce(0, 0, (ForwardMovementSpeed * Time.deltaTime));
        float Horizontal = Input.GetAxis("Horizontal") * HorizontalMovementSpeed * Time.deltaTime;
        Player.linearVelocity = new Vector3(Horizontal, Player.linearVelocity.y, Player.linearVelocity.z);
        if (Input.GetKey(KeyCode.Space) && OnTheGround)
        {
            OnTheGround = false;
            Player.AddForce(0, (JumpForce * Time.deltaTime), 0);
        }
        if (PlayerTransform.position.y <= 0.8)
        {
            FallSound.Play();
            gameManager.GameOver();
            Player.AddForce(0, -1000 * Time.deltaTime, 0);
        }
    }
}
