
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "ScriptableObjects/Enemy Data")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private float dañoDerecha;//Ctrl + . para crear get y set
    [SerializeField] private float dañoIzquierda;
    [SerializeField] private float velocidadDaño;
    [SerializeField] private float dañoArriba;
    [SerializeField] private float dañoAbajo;

    public float DañoDerecha { get => dañoDerecha; set => dañoDerecha = value; }
    public float DañoIzquierda { get => dañoIzquierda; set => dañoIzquierda = value; }
    public float VelocidadDaño { get => velocidadDaño; set => velocidadDaño = value; }
    public float DañoArriba { get => dañoArriba; set => dañoArriba = value; }
    public float DañoAbajo { get => dañoAbajo; set => dañoAbajo = value; }
}

