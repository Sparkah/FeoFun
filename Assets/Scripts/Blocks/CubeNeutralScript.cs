using UnityEngine;

public class CubeNeutralScript : MonoBehaviour
{
    [SerializeField] GameObject cubeFriend;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMover>() != null)
        {
            Debug.Log("Player -> NeutralCube");
            GameObject player = other.GetComponent<PlayerMover>().gameObject;
            AddNeutralCubeToStack(player);
        }
    }

    private void AddNeutralCubeToStack(GameObject player)
    {
        GameObject newCubeFriend = Instantiate(cubeFriend);
        newCubeFriend.transform.SetParent(player.transform);
        player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1, player.transform.position.z);
        newCubeFriend.transform.position = new Vector3(player.transform.position.x, player.transform.position.y-1, player.transform.position.z);
        Destroy(gameObject);
    }
}