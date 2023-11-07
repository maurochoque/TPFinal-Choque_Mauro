using UnityEngine;
using System.Collections;

public class EnemyMovY : MonoBehaviour
{
    public Rigidbody2D rbEnemy;
    //public Transform pointA;
    //public Transform pointB;
    //public float speed = 2.0f;
    public EnemyData enemyData;
    private void Start()
    {
        //StartCoroutine(Patrol());
        rbEnemy=GetComponent<Rigidbody2D>();
        
    }
    private void Update() {
        transform.Translate(Vector3.down * enemyData.DañoAbajo * Time.deltaTime);
    }
  


}
