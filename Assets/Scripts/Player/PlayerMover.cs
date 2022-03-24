using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;

    void FixedUpdate()
    {
        gameObject.transform.position += Vector3.forward * speed;
    }
}