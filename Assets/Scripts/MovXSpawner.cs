using UnityEngine;
using System.Collections;
using UnityEngine.UIElements;

public class MovXSpawner : MonoBehaviour
{
    private GameObject objeto1;
    //public Rigidbody2D rbSpawner;
    private Vector3 startPosPuntoC1;
   
    public EnemyData enemyData;
    private void Start()
    {
        //rbSpawner=GetComponent<Rigidbody2D>();
        objeto1=GameObject.Find("puntoC1");
        //Transform transformObjeto1 = objeto1.transform;
        //transformObjeto1.position = new Vector3(0, 0, 0);
        startPosPuntoC1=objeto1.transform.position;

        
        //transform.position= new Vector3(50,transform.position.y, transform.position.z);
        //startPos=transform.position;
        
    }
    private void Update() {
        objeto1.transform.Translate(Vector3.right * enemyData.DañoDerecha * Time.deltaTime);
        if(objeto1.transform.position.x>=95.0f){
            objeto1.transform.position=startPosPuntoC1;
        }

    }
    
}
