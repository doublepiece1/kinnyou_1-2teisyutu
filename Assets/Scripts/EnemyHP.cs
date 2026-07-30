using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int maxHP = 100;

    private int currentHP;

    void Start()
    {
        currentHP = maxHP;
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;

        if (currentHP <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        GameManager.Instance.GameClear();

        Destroy(gameObject);
    }
}
