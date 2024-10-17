using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Image soundOnIcon;
    [SerializeField] Image soundOffIcon;
    private bool muted = false;
    void Start()
    {
        
    }
    public void OnButtonPress()
    { 
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }

        else
        {
            muted = false;
            AudioListener.pause = false;
        }
    }

    private void Load()   // https://www.google.com/search?sca_esv=06cf028af5c7a812&cs=0&sxsrf=ADLYWIL5393qlp42YbkCvIA2kNRYeZwu3Q:1728922755505&q=Unity+mute+Audio+Listener&tbm=vid&source=lnms&fbs=AEQNm0BZDILf8XWKqSgqw26hAKzqx5LlKuFsoJhPXM59bIe4Uy-W2mQFSvoVhxpJ273EZTaWVlFYAfLGNRRPrpfngVtghSlSjle83RNTqxN3uZWh2PaEAwWOK5MH45mYvWZ5CqvRUZfHwJ1u9SfmiiXf2OrnLdmXxvVLeZG3ExyYTTHfxX053pVdd20SoW5wXD0lGY-DvjUs3aoERflpF9mDvB1tT-QNwg&sa=X&ved=2ahUKEwi8jb6Vo46JAxXaRvEDHS9tCTAQ0pQJegQIFRAB&biw=1163&bih=501&dpr=1.5#fpstate=ive&vld=cid:57040808,vid:AFcHsKd_aMo,st:0
                        // min 3:07
    {

    }
}
