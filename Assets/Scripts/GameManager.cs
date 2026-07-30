using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TMP_Text clearText;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        clearText.gameObject.SetActive(false);
    }

    public void GameClear()
    {
        clearText.gameObject.SetActive(true);
    }
}
