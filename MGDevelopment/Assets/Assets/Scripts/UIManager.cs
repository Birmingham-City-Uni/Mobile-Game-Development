using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static bool isGameActive = false;
    [Header("Panels")]
    public GameObject mainMenuPanel;
    public GameObject hudPanel;
    public GameObject gameOverPanel;
    public GameObject playerCar;

    void Start()
    {
        Time.timeScale = 1f;
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        isGameActive = false;
        mainMenuPanel.SetActive(true);
        hudPanel.SetActive(false);
        gameOverPanel.SetActive(false);

        if (playerCar != null)
        {
            playerCar.SetActive(false);
        }
    }

    public void StartGame()
    {
        isGameActive = true;
        mainMenuPanel.SetActive(false);
        hudPanel.SetActive(true);
        gameOverPanel.SetActive(false);

        if (playerCar != null)
        {
            playerCar.transform.position = new Vector3(0f, -3.5f, 0f);
            playerCar.SetActive(true);
        }
    }

    public void ShowGameOver()
    {
        isGameActive = false;
        mainMenuPanel.SetActive(false);
        hudPanel.SetActive(false);
        gameOverPanel.SetActive(true);

        if (playerCar != null)
        {
            playerCar.SetActive(false);
        }
    }

    public void RestartGame()
    {
        isGameActive = true;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
