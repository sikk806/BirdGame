using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public AudioClip GameOverSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = PlayerPrefs.GetInt("Score", 0);
        scoreText.text = score.ToString();

        GetComponent<AudioSource>().PlayOneShot(GameOverSound);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTryAgainPressed()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnQuitPressed()
    {
        Application.Quit();
    }
}
