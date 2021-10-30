using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    public GameObject characters;
    public GameObject menuPrincipal;
    public GameObject store;
    public Text CantCoin; 

    public GameObject setting;
    //public GameObject back;

    public int Coins;
    public static int Cantcoints;

    // Start is called before the first frame update
    void Start()
    {
        CantCoin.text = Coins.ToString();
        Cantcoints = Coins;
    }
    void Update()
    {
        CantCoin.text = Cantcoints.ToString();
    }

    //Metodo para ver el menu de Personajes 
    public void Characters()
    {
        characters.SetActive(true);
        menuPrincipal.SetActive(false);
    }
    //Metodo para ver el menu principal
    public void MenuPrincipal()
    {
        menuPrincipal.SetActive(true);
        characters.SetActive(false);
        store.SetActive(false);
    }
    //Metodo para ver el menu de de compra o videos
    public void Store()
    {
        store.SetActive(true);
        menuPrincipal.SetActive(false);
    }

    //Contador
    int cantidad = 4;

    //Metodo para el shop, sirve para agregar las monedas por ver video(Tocar el boton en este caso)
    //El contador lo hice con la idea de que algunos de los videos puedan verse mas de una vez al dia.
    public void Buy1()
    {
        if(cantidad >= 1)
        {
            Cantcoints = Cantcoints + 75;
        }      
        cantidad--;
        CantCoin.text = Cantcoints.ToString();        
    }
    int cantidad1 = 3;
    public void Buy2()
    {
        if(cantidad1 >= 1)
        {
            Cantcoints = Cantcoints + 2000;
        }      
        cantidad1--;
        CantCoin.text = Cantcoints.ToString();        
    }
    int cantidad2 = 2;
    public void Buy3()
    {
        if(cantidad2 >= 1)
        {
            Cantcoints = Cantcoints + 10000;
        }      
        cantidad2--;
        CantCoin.text = Cantcoints.ToString();        
    }
    int cantidad3 = 1;
    public void Buy4()
    {
        if(cantidad3 >= 1)
        {
            Cantcoints = Cantcoints + 50000;
        }      
        cantidad3--;
        CantCoin.text = Cantcoints.ToString();        
    }

    //Cambio de scena
    public void GameScene()
    {
        SceneManager.LoadScene("Game");
    }

    //Metodo para el menu Settings
    public void Setting()
    {
        setting.SetActive(true);
    }
    //Metodo para retroceder desde el menu Settings
    public void Back()
    {
        setting.SetActive(false);
    }

}
