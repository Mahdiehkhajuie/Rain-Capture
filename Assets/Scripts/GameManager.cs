using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score = 0;
    public int health = 3;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI healthText;

    public int maxMissedDrops = 15;
    private int missedDrops = 0;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    private void Start()
    {
        UpdateUI();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateUI();
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        UpdateUI();

        if (health <= 0)
        {
            Debug.Log("You Lost!");
        }
    }

    public void MissedDrop()
    {
        missedDrops++;
        Debug.Log("Missed Drops: " + missedDrops);

        if (missedDrops >= maxMissedDrops)
        {
            Debug.Log("You Lost!");
        }
    }

    void UpdateUI()
    {
        scoreText.text = "Score: " + score;
        healthText.text = "Health: " + health;
    }
}