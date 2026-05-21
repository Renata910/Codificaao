using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public int dano;
    public int vida;
    public bool specialAttack;


    public void Awake()
    {
        dano = Random.Range(1, 21);
        specialAttack = dano > 10;
    }

    public void Atacar()
    {
        if(specialAttack)
        {

            Debug.Log(" Super Ataque" + dano);
        }
        else
        {

            Debug.Log("Super Ataque");
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

   
}
