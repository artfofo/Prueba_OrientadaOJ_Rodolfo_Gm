using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//datos existentes sean otorgados a player1 desde el scrip constructor personaje
public class Player1 : MonoBehaviour
{
    //1.- se llama al plano ConstructorPersonaje
    //2.-se le da un ID Bob
    //3.-sE inicializa el dato como nuevo objeto new

    public ConstructorPersonaje Bob = new ConstructorPersonaje();
    Animator animarplayer;
    SpriteRenderer spritePlayer;
    Rigidbody2D fisicasRB2D;
    public int fuerzasalto=5;
    // Start is called before the first frame update
    void Start()
    {
        
        Bob.nombre = "player";
        gameObject.name = Bob.nombre;
        Bob.vida = 10;
        Bob.daño = 2;
        //iniciar animación
        animarplayer = GetComponent <Animator>();
        spritePlayer = GetComponent<SpriteRenderer>();
        fisicasRB2D = GetComponent<Rigidbody2D>();



    }

    // condicion para velocidad/movimiento
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape ))
        {
            fisicasRB2D.AddForce(Vector2.up * fuerzasalto, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            Movimiento(fisicasRB2D,4f);
            animarplayer.SetBool("Velocidad", true);
            spritePlayer.flipX = false;
            
        } 
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            Movimiento(fisicasRB2D, -4f);
            animarplayer.SetBool("Velocidad", true);
            spritePlayer.flipX = true;
        }
        else
        {
            animarplayer.SetBool("Velocidad", false);
        }
    }
    //registrar mov a la izquierda a partir de la lectura del rigidbody
   private void Movimiento(Rigidbody2D rb,float v)
    {
        rb.velocity = new Vector2(v, rb.velocity.y);

    }
    //colisiones con diferentes objetos
   // private void OnCollisionEnter2D(Collision2D collision)
//    {
       // Bob.registroColision(nombreOBJ, colision)
  //  }
}
