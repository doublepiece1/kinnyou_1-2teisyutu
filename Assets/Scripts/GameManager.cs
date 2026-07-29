using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject enemyPrefab;
    public Transform[] spawnPoints;
    public int startEnemyCount = 5;
    public int clearCount = 10;
    private int killCount = 0;
    void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        for (int i = 0; i < startEnemyCount; i++)
        {
            SpawnEnemy();
        }
    }
    public void EnemyKilled()
    {
        killCount++;

        Debug.Log("撃破数 : " + killCount + " / " + clearCount);

        if (killCount >= clearCount)
        {
            GameClear();
        }
        else
        {
            SpawnEnemy();
        }
    }
    void SpawnEnemy()
    {
        int index = Random.Range(0, spawnPoints.Length);

        Instantiate(enemyPrefab,
                    spawnPoints[index].position,
                    Quaternion.identity);
    }
    void GameClear()
    {
        Debug.Log("ゲームクリア！");
    }
}
