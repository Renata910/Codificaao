using UnityEngine;

public class Peronagem : MonoBehaviour
{

    public int vida;
    public float velocidade;
    public int dano;

    
    public void Attack()
    {
        vida -= dano;
    }

    
}
