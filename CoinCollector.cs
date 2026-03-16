using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public int coinCount = 0;
    public float minX = -8f;
    public float maxX = 8f;
    public float minY = -2f;
    public float maxY = 3f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            coinCount++;
            Debug.Log("Monedas: " + coinCount);

            // Mover la moneda a posicion aleatoria
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            other.transform.position = new Vector2(randomX, randomY);
        }
    }
}