using UnityEngine;
using TMPro;

public class CarrotsManager : MonoBehaviour
{
    public int CarrotsCount { get; private set; }


    [SerializeField] private TMP_Text carrotsDisplay;

    private void Start()
    {
        CarrotsCount = 0;
        Carrots.AddOnCarrotCollectedEventListener(ChangeCarrots);
    }

    private void OnGUI()
    {
        carrotsDisplay.text = CarrotsCount.ToString();
    }

    public void ChangeCarrots()
    {
        CarrotsCount++;
    }
}
