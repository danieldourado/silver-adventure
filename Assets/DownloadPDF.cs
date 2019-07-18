using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownloadPDF : MonoBehaviour
{
    // Start is called before the first frame update
    public void DoDownloadPDF()
    {
        Application.OpenURL("https://rebrand.ly/Cabal360");
    }

    public void Dial()
    {
        Application.OpenURL("tel:+556121018900");
    }

    public void Resume()
    {
        Application.OpenURL("https://career4.successfactors.com/career?company=sicoob");
    }
}
