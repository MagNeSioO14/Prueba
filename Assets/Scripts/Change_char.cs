using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change_char : MonoBehaviour
{
    //variable para saber en que ubicacion va a estar el vector
    public int Selected = 0;
    //Vector de objetos, en este caro los personajes
    public GameObject[] Characters;
    //Vector para saber si tiene o no el personaje 
    public bool[] unlock;
    //Vector que contiene el valor del personaje
    public int[] Valor;
    //Vector con los nombes
    public string[] Names;
    public Text namestxt;

    public GameObject Buy;
    public GameObject play;
    public GameObject amount;

    int contcoin;


    // Start is called before the first frame update
    void Start()
    {
        contcoin = Controller.FindObjectOfType<Controller>().Coins; 
    }

    //Metodo del boton siguiente, en la seleccion de personajes.
    public void Next()
    {
        Text texto;

        texto = amount.GetComponent<Text>();
        Characters[Selected].SetActive(false);
        Selected++;
        if(Selected >= Characters.Length)
        {
            Selected = 0;
        }
        
        if(unlock[Selected] == false)
        {
            Buy.SetActive(true);
            play.SetActive(false);
            texto.text = Valor[Selected].ToString();
            Characters[Selected].GetComponent<SpriteRenderer>().color = Color.black;
        }
        else{
            Buy.SetActive(false);
            play.SetActive(true);
            Characters[Selected].GetComponent<SpriteRenderer>().color = Color.white;
        }
        namestxt.text = Names[Selected];
        Characters[Selected].SetActive(true);
    }
    //Metodo del boton anterios, en la seleccion de personajes.
    public void Previous()
    {
        Text texto;

        texto = amount.GetComponent<Text>();
        Characters[Selected].SetActive(false);
        Selected--;
        if(Selected < 0)
        {
            Selected = Characters.Length-1;
        }
        if(unlock[Selected] == false)
        {
            Buy.SetActive(true);
            play.SetActive(false);
            texto.text = Valor[Selected].ToString();
            Characters[Selected].GetComponent<SpriteRenderer>().color = Color.black;
        }
        else{
            Buy.SetActive(false);
            play.SetActive(true);
            Characters[Selected].GetComponent<SpriteRenderer>().color = Color.white;
        }
        namestxt.text = Names[Selected];

        Characters[Selected].SetActive(true);
    }

    //Metodo para comprar personajes
    //Primero checamos que no lo tenga, despues que tenga el valor que vale el personaje,
    //una vez comprado lo desbloqueamos(Con un simple cambio de color) y cambiamos los botones
    public void BuyChar()
    {
        if(unlock[Selected] == false)
        {
            if(Controller.Cantcoints >= Valor[Selected])
            {
                Controller.Cantcoints -= Valor[Selected]; 
                unlock[Selected] = true;
            }
        } 
        if(unlock[Selected] == true)
        {
            Buy.SetActive(false);
            play.SetActive(true);
            Characters[Selected].GetComponent<SpriteRenderer>().color = Color.white;
        }
        Debug.Log(Controller.Cantcoints);
    }
}
