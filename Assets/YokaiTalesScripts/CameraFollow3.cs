using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float altura = 9f; // um pouco pra cima
    public float distancia = 13f; // atrás
    public float smoothSpeed = 5f;

    void LateUpdate()
    {
        if (player == null) return;

        // Pega a posição atrás do personagem, usando a direção dele
        Vector3 posAtras = player.position - player.forward * distancia + Vector3.up * altura;
        
        // Vai suavemente pra lá
        transform.position = Vector3.Lerp(transform.position, posAtras, smoothSpeed * Time.deltaTime);
        
        // Olha pro personagem
        transform.LookAt(player.position + Vector3.up * 1f); // +1 pra mirar no peito, não no pé
    }
}