using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour
{
    public int maxHP = 100;
    private int currentHP;

    private GameObject HPUI;
    private Slider hpSlider;
    void Start()
    {
        currentHP = maxHP;
        hpSlider = HPUI.transform.Find("HPbar").GetComponent<Slider>();
        hpSlider.value = 1f;
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;
        this.currentHP = currentHP;
        if (currentHP <= 0)
        {
            Die();
            HideStatusUI();
        }
    }

    public int GetHp() 
    {
        return currentHP;
    }

    public int GetMaxHp() 
    {
        return maxHP;
    }
    public void HideStatusUI() 
    {
        HPUI.SetActive(false);
    }
    public void UpdateHPValue()
    {
        hpSlider.value = (float)GetHp() / (float)GetMaxHp();
    }
    void Die()
    {
        GameManager.Instance.GameClear();

        Destroy(gameObject);
    }
}
