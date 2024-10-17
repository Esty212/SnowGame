using UnityEngine;

public class Carrots : MonoBehaviour
{
    [SerializeField] private int carrotValue;
    private bool hasTriggered;

    private CarrotsManager carrotsManager;

    private void Start()
    {
        carrotsManager = CarrotsManager.instance;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true;
            carrotsManager.ChangeCarrots(carrotValue);
            Destroy(gameObject);
        }
    }

}
