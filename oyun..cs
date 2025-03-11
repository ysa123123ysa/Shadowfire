using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene"); // Oyun sahnesine geçiş
    }

    public void OpenLoadout()
    {
        SceneManager.LoadScene("LoadoutScene"); // Silah seçim ekranı
    }

    public void OpenAgents()
    {
        SceneManager.LoadScene("AgentsScene"); // Ajan seçim ekranı
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene("SettingsScene"); // Ayarlar menüsü
    }

    public void QuitGame()
    {
        Application.Quit(); // Oyundan çık
    }
}using UnityEngine;
using UnityEngine.UI;

public class ButtonHoverEffect : MonoBehaviour
{
    public Color normalColor = Color.white;
    public Color hoverColor = Color.red;
    private Button button;
    private Image image;

    void Start()
    {
        button = GetComponent<Button>();
        image = button.GetComponent<Image>();
    }

    public void OnHover()
    {
        image.color = hoverColor;
    }

    public void OnExit()
    {
        image.color = normalColor;
    }
}void Update()
{
    transform.Rotate(0, 10 * Time.deltaTime, 0); // Yavaşça döndür
}