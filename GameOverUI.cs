using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private GameObject gameOverUIObject;
    public static GameOverUI Instance;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
    public void ShowGameOver()
    {
        gameOverUIObject.SetActive(true);
    }
    public void HideGameOver()
    {
        gameOverUIObject.SetActive(false);
    }
}
