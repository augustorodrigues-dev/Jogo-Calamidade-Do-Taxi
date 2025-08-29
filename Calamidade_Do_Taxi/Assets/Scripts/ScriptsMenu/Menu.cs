using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{

    public GameObject textosMenu;

    public GameObject textosOpcoes;
    public void botaoNovoJogo()
    {
        SceneManager.LoadScene("Casa Inicial");
    }
    public void botaoSair()
    {
        Application.Quit();
    }

    public void botaoOpcoes()
    {
        textosMenu.SetActive(false);
        textosOpcoes.SetActive(true);
    }

    public void botaoVoltar()
    {
        textosMenu.SetActive(true);
        textosOpcoes.SetActive(false);
    }
}
