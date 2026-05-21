using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour


{

    public List<Inimigo> inimigoList = new();


    private void Start()
    {
        for (int i = 0; i < inimigoList.Count; i++)
        {

            inimigoList[i].Atacar();
        }
    }

}

