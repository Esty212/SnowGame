
using UnityEngine;
using TMPro;

public class CarrotsManager : MonoBehaviour
{
    public static CarrotsManager instance;

    private int carrotsCount;

    [SerializeField] private TMP_Text carrotsDisplay;

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    private void OnGUI()
    {
        carrotsDisplay.text = carrotsCount.ToString();
    }

    public void ChangeCarrots(int amount)
    {
        carrotsCount += amount;
    }

}
