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
    // Start is called before the first frame update
    public void DoDownloadPDF2017()
    {
        Application.OpenURL("https://www.cabal.com.br/relatorio/");
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
