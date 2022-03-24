using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Button buttonTapToPlay;
    void Start()
    {
        Time.timeScale = 0;
    }

    public void StartGameButton()
    {
        Time.timeScale = 1;
        buttonTapToPlay.gameObject.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}