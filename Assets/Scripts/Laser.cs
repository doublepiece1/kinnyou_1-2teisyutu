using UnityEngine;

public class Laser : MonoBehaviour
{
    public float lifeTime = 2f;

     void Start()
    {
        Destroy(gameObject, lifeTime);    
    }
}
