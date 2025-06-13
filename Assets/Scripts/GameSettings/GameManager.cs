using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int Player1Score { get; set; } = 0;
    public int Player2Score { get; set; } = 0;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

            DontDestroyOnLoad(gameObject);
            LogCurrentSettings();
        }
        else
        {
            //Destroy gameObject when switching back the this scene (Need only 1 Instance of this class)
            Destroy(gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int player, int newScore)
    {
        if (player == 1)
        {
            Player1Score = newScore;
        }
        else
        {
            Player2Score = newScore;
        }
        Debug.Log($"[GameManager] Player{player}Score updated to: {newScore}");
    }

    public void LogCurrentSettings()
    {
        Debug.Log($"[GameManager Settings] Player1Score: {Player1Score}");
        Debug.Log($"[GameManager Scores] Player2Score: {Player2Score}");
    }
}
