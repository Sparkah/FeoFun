using UnityEngine;

public class CubeFriendScript : MonoBehaviour
{
    [SerializeField] Material cubeNeutralMaterial;
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<CubeNeutralScript>()!=null)
        {
            Debug.Log("FriendCube -> NeutralCube");
            GameObject player = gameObject.GetComponentInParent<PlayerMover>().gameObject;
            Destroy(other.gameObject);
            AddNeutralCubeToStack(player);
        }
        if(other.GetComponent<CubeEnemyScript>()!=null)
        {
            Debug.Log("FriendCube -> EnemyCube");
            gameObject.transform.SetParent(null);
            gameObject.GetComponent<Renderer>().material = cubeNeutralMaterial;
        }
    }
    private void AddNeutralCubeToStack(GameObject player)
    {
        GameObject newCubeFriend = Instantiate(gameObject);
        newCubeFriend.transform.SetParent(player.transform);
        player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1, player.transform.position.z);
        newCubeFriend.transform.position = new Vector3(player.transform.position.x, 0.5f, player.transform.position.z);
    }
}