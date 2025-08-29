using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void botaoNovoJogo()
    {
        SceneManager.LoadScene("Casa Inicial");
    }
    public void botaoSair()
    {
        Application.Quit();
    }
}
