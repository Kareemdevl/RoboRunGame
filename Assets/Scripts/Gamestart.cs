using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamestart : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

