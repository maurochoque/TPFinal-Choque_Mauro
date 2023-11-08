using UnityEngine;
using System.Collections;

public class EnemyPatrol : MonoBehaviour
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
        transform.Translate(Vector3.right * enemyData.DañoIzquierda * Time.deltaTime);
    }
}
