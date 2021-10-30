using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public GameObject pause;
    public GameObject back;

    //Metodo para pausar el juego
    public void Pause()
    {
        pause.SetActive(true);
        back.SetActive(false);
    }
    //Metodo para retroceder al menu del juego
    public void Back()
    {
        pause.SetActive(false);
        back.SetActive(true);
    }

    //Metodo para cambiar de escena al menu principal
    public void MenuScene()
    {
        SceneManager.LoadScene("PrincipalMenu");
    }

    
}
