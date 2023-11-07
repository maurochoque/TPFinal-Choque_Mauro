using UnityEngine;
using System.Collections;
using UnityEngine.UIElements;

public class MovXSpawner : MonoBehaviour
{
    private GameObject objeto1;
    private GameObject objeto2;
    
    private Vector3 startPosPuntoC1;
    private Vector3 startPosPuntoC2;

    public EnemyData enemyData;
    private void Start()
    {
        
        objeto1=GameObject.Find("puntoC1");
        startPosPuntoC1=objeto1.transform.position;

        objeto2=GameObject.Find("puntoC2");
        startPosPuntoC2=objeto2.transform.position;

    }
    private void Update() {
        objeto1.transform.Translate(Vector3.right * enemyData.DañoDerecha * Time.deltaTime);
        if(objeto1.transform.position.x>=95.0f){
            objeto1.transform.position=startPosPuntoC1;
        }

        objeto2.transform.Translate(Vector3.right * enemyData.DañoIzquierda * Time.deltaTime);
        if(objeto2.transform.position.x<=5f){
            objeto2.transform.position=startPosPuntoC2;
        }

    }
    
}
