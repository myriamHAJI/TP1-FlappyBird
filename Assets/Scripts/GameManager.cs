using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public bool gameOver;
    public int score;

    public TextMeshProUGUI scoreText;
    public GameObject gameOverScreen;
    public Image flashImage;

    public AudioClip jumpSound;
    public AudioClip scoreSound;
    public AudioClip hitSound;

    private AudioSource audioSource;

    void Start()
    {
        Time.timeScale = 1;
        gameOver = false;
        score = 0;

        audioSource = GetComponent<AudioSource>();

        scoreText.text = score.ToString();
        gameOverScreen.SetActive(false);
        flashImage.gameObject.SetActive(false);
    }

    void Update()
    {
        if (gameOver && Keyboard.current.rKey.wasPressedThisFrame)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void PlayJumpSound()
    {
        audioSource.PlayOneShot(jumpSound);
    }

    public void AddScore()
    {
        if (!gameOver)
        {
            score++;
            scoreText.text = score.ToString();
            audioSource.PlayOneShot(scoreSound);
        }
    }

    public void EndGame()
    {
        if (gameOver)
        {
            return;
        }

        gameOver = true;
        audioSource.PlayOneShot(hitSound);

        Time.timeScale = 0;
        StartCoroutine(ShowFlash());
    }

    IEnumerator ShowFlash()
    {
        flashImage.gameObject.SetActive(true);
        flashImage.color = Color.white;

        yield return new WaitForSecondsRealtime(0.12f);

        flashImage.gameObject.SetActive(false);
        gameOverScreen.SetActive(true);
    }
}