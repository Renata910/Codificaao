using UnityEngine;

public class NPC : MonoBehaviour
{
    public string nome;
    public bool interagivel;
    public int idade;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NPC roberto = new NPC();
        roberto.nome = "Roberto";
        roberto.idade = 15;
        roberto.interagivel = true;

        NPC julia = new NPC();
        julia.nome = "Julia";
        julia.idade = 18;
        julia.interagivel = false;
    }

    
}
