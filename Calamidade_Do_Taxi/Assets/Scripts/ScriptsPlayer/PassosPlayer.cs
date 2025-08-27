using UnityEngine;

public class PassosPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource somPassosSource;
    [SerializeField] private CharacterController characterController;

    // --- NOVAS VARIÁVEIS ---
    [Header("Sons de Passos")] // Cria um título no Inspector para organizar
    [SerializeField] private AudioClip somAndando;
    [SerializeField] private AudioClip somCorrendo;

    [SerializeField] private AudioClip somAgachado;

    [Header("Configurações de Ritmo")]
    [Tooltip("Controla a velocidade do som ao andar")]
    [SerializeField] private float pitchAndando = 1.0f;
    [Tooltip("Controla a velocidade do som ao correr. Um valor maior significa passos mais rápidos.")]
    [SerializeField] private float pitchCorrendo = 1.0f;

    [SerializeField] private float pitchAgachado = 1.0f;

    void Update()
    {
        // A condição principal continua a mesma: está no chão e se movendo?
        if (characterController.isGrounded && characterController.velocity.magnitude > 0.1f)
        {
            // --- NOVA LÓGICA ---
            // Agora, verificamos se a tecla Left Shift está pressionada
            bool estaCorrendo = Input.GetKey(KeyCode.LeftShift);
            bool estaAgachado = Input.GetKey(KeyCode.LeftControl);

            // Escolhemos o som e o ritmo com base no estado (correndo ou andando)
            if (estaCorrendo)
            {
                // Se estiver correndo, usamos o som e o pitch de corrida
                somPassosSource.clip = somCorrendo;
                somPassosSource.pitch = pitchCorrendo;
            }
            else if (estaAgachado)
            {
                // Se não, usamos o som e o pitch de caminhada
                somPassosSource.clip = somAgachado;
                somPassosSource.pitch = pitchAgachado;
            }
            else
            {
                somPassosSource.clip = somAndando;
                somPassosSource.pitch = pitchAndando;
            }

            // A lógica para tocar o som continua a mesma: só toca se não estiver tocando
            if (!somPassosSource.isPlaying)
            {
                somPassosSource.Play();
            }
        }
        else
        {
            // Para o som se o jogador parar ou pular
            somPassosSource.Stop();
        }
    }
}