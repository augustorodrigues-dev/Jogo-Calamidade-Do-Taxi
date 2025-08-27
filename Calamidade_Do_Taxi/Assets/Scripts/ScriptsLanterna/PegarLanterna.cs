using UnityEngine;

public class PegarLanterna : MonoBehaviour
{
    public GameObject lanternaNaMao;

    public KeyCode teclaParaPegar = KeyCode.E;

    private bool podePegar = false;

    private GameObject lanternaNoChao;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            podePegar = true;
            lanternaNoChao = this.gameObject; 
            Debug.Log("Player entrou na área da lanterna. Pressione 'E' para pegar.");
            
        }
    }

    
    private void OnTriggerExit(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            podePegar = false;
            Debug.Log("Player saiu da área da lanterna.");
            
        }
    }

    
    private void Update()
    {
        
        if (podePegar && Input.GetKeyDown(teclaParaPegar))
        {
            
            Pegar();
        }
    }

    private void Pegar()
    {
        
        if (lanternaNaMao != null)
        {
            lanternaNaMao.SetActive(true);
        }

        
        if (lanternaNoChao != null)
        {
            Destroy(lanternaNoChao);
        }
        
        Debug.Log("Lanterna pega!");
    }
}