using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int Player1Score { get; set; } = 0;
    public int Player2Score { get; set; } = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            //Destroy gameObject when switching back the this scene (Need only 1 instance of this class)
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
}
