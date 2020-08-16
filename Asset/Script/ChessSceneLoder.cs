using UnityEngine.SceneManagement;
using UnityEngine;

public class ChessSceneLoder : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
