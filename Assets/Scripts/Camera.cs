using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform CameraPosition;
    [SerializeField] private Transform PlayerPosition;
    private Vector3 DistanceFromPlayer = new Vector3(0f, 2.451f, -6.428f);
    private void Update()
    {
        CameraPosition.position = PlayerPosition.position + DistanceFromPlayer;
    }
}
