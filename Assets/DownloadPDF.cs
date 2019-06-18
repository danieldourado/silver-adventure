using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownloadPDF : MonoBehaviour
{
    // Start is called before the first frame update
    public void DoDownloadPDF()
    {
        Application.OpenURL("http://bit.ly/cabalbrasil360");
    }
}
