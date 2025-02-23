using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUIController : MonoBehaviour
{
    public void RetryGame()
    {
        SceneManager.LoadScene(1);
    }
}
