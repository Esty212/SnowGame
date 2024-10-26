using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    [SerializeField] private CarrotsManager carrotsManager;
    public GameObject text_YouWon;
    public GameObject text_Almost;

    private void Awake()
    {
        text_YouWon.SetActive(false);
        text_Almost.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") )
        {
            if (carrotsManager.CarrotsCount == 3)
            {
                text_YouWon.SetActive(true);
                Time.timeScale = 0;
            }
            else text_Almost.SetActive(true);
            
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (text_Almost)
            text_Almost.SetActive(false);
    }

}
