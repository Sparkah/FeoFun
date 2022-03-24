using UnityEngine;

public class FinishGameZoneScript : MonoBehaviour
{
    private UIManager uIManager;
    private void Start()
    {
        uIManager = FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerMover>()!=null || other.GetComponent<CubeFriendScript>()!=null)
        {
            Debug.Log("Player -> WinGameCube");
            uIManager.RestartGame();
        }
    }
}