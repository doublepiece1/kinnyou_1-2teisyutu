using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 1;
    public float lifeTime = 5f;

    void Update()
    {
        // X²•ûŒü‚Ö”ò‚Ô
        transform.position += Vector3.right * speed * Time.deltaTime;
    }

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("“–‚½‚Á‚½‘ŠèF" + other.name);

        if (other.CompareTag("Enemy"))
        {
            Debug.Log("“G‚É–½’†I");

            EnemyHealth enemy = other.GetComponent<EnemyHealth>();

            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }

            Destroy(gameObject);
        }
    }
}
