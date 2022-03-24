using UnityEngine;

public class CameraFollowPlayerScript : MonoBehaviour
{
    private GameObject player;

    void Start()
    {
        player = FindObjectOfType<PlayerMover>().gameObject;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, player.transform.position.z-8.5f);
    }
}