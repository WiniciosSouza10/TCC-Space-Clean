using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManeger : MonoBehaviour
{
   [SerializeField] private GameObject painelMenuInicial;
   [SerializeField] private GameObject painelOpcoes;
   public void Jogar()
   {
     SceneManager.LoadScene(1);
   }

   public void AbrirOpcoes()
   {
    painelOpcoes.SetActive(true);

    painelMenuInicial.SetActive(false);
   }

   public void FecharOpcoes()
   {
     painelOpcoes.SetActive(false);

     painelMenuInicial.SetActive(true);
   }

   public void SairJogo()
   {
     Application.Quit();
   }
    

}
