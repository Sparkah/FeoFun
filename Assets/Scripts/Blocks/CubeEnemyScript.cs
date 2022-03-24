using UnityEngine;

public class CubeEnemyScript : MonoBehaviour
{
    private UIManager uIManager;
    void Start()
    {
        uIManager = FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMover>() != null)
        {
            Debug.Log("Player -> EnemyCube");
            uIManager.RestartGame();
        }
    }
}