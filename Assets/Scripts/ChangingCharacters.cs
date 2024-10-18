using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingCharacters : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;

    public GameObject icePowerPic;
    public GameObject firePowerPic;
    public GameObject windPowerPic;

    private void Awake()
    {
        icePowerPic.SetActive(true);
        firePowerPic.SetActive(false);
        windPowerPic.SetActive(false);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            PlayerSwitch();
        }

    }

    void PlayerSwitch()
    {
        if (player1.activeSelf)
        {
            player2.SetActive(true);
            player3.SetActive(false);
            player1.SetActive(false);

            icePowerPic.SetActive(false);
            firePowerPic.SetActive(true);
            windPowerPic.SetActive(false);

        }
        else if (player2.activeSelf)
        {
            player2.SetActive(false);
            player3.SetActive(true);
            player1.SetActive(false);

            icePowerPic.SetActive(false);
            firePowerPic.SetActive(false);
            windPowerPic.SetActive(true);


        }
        else if (player3.activeSelf)
        {
            player2.SetActive(false);
            player3.SetActive(false);
            player1.SetActive(true);

            icePowerPic.SetActive(true);
            firePowerPic.SetActive(false);
            windPowerPic.SetActive(false);

        }
    }
}
