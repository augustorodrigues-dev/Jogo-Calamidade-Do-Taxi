using UnityEngine;

public class DoorRotation : MonoBehaviour
{
    private bool isOpen = false;

    private bool podeAbrir = false;
    private Quaternion closedRotation;
    private Quaternion openRotation;
    public float rotationSpeed = 2f;

     private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            podeAbrir = true; 
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            podeAbrir = false;
            
            
        }
    }

    void Start()
    {
        closedRotation = transform.rotation;
        openRotation = Quaternion.Euler(transform.eulerAngles + new Vector3(0, 120, 0));
    }

    void Update()
    {
        if (podeAbrir)
        {
            if (Input.GetKeyDown(KeyCode.E))
        {
            isOpen = !isOpen;
        }

            if (isOpen)
                transform.rotation = Quaternion.Lerp(transform.rotation, openRotation, Time.deltaTime * rotationSpeed);
            else
                transform.rotation = Quaternion.Lerp(transform.rotation, closedRotation, Time.deltaTime * rotationSpeed);
    }
        }
        
}
