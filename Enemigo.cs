using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//rodolfo García Martínez

public class Enemigo : MonoBehaviour
{
    public ConstructorPersonaje pala = new ConstructorPersonaje();
    public ConstructorPersonaje camionCons = new ConstructorPersonaje();
    public GameObject camionObjeto;
    public GameObject PalaObjeto;


    // se aplica lo mismo que en player 1 pero ahora para mencionar al enemigo llamandolo desde el constructor
    void Start()
    {
        //cambiar info de los datos
        //encontrar desde unity un objeto con el nombre enemigo1
        PalaObjeto = GameObject.Find("Enemigo1");
        //encontrar dentro de unity un objeto con el nombre enemigo2
        // clasificar a los dueños de estos datos
        camionObjeto = GameObject.Find("Enemigo2");
        //++++++++++++++++++++++++++objeto camion++++++++++++++++
        camionCons.nombre = "Camion_Malo";
        camionObjeto.name = camionCons.nombre;
        camionCons.vida = 20;
        camionCons.daño = 5;

        
        //++++++++++++++++++++++++++++++++++++++++++++++
        



        //++++++++++++++++++++bjetopala+++++++++++++++++
        pala.nombre = "Pala";
        PalaObjeto.name = pala.nombre;
        pala.vida = 20;
        pala.daño = 2;
        //++++++++++++++++++++++++++++++++++++++++++++++
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
