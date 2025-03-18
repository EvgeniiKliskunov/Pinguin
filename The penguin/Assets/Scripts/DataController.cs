using TMPro; 
using UnityEngine;

public class DataController : MonoBehaviour
{
    public GameObject TextFishs;
    void Start()
    {
        if( PlayerPrefs.HasKey( "Fishs" )) TextFishs.GetComponent<TMP_Text>().text = PlayerPrefs.GetInt( "Fishs" ).ToString();
        else TextFishs.GetComponent<TMP_Text>().text = "0";
    }
}
