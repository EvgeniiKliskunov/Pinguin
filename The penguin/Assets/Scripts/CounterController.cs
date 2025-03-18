using TMPro; 
using UnityEngine;

public class CounterControlle : MonoBehaviour
{
    private int _count;
    public int DeltaCount;
    public float DeltaTime;

    public float TimeCounter;
    public float MinTimeCounter;
    public float DeltaTimeCounter;

    public GameObject TextCount;


    public void GameOver()
    {
        CancelInvoke( "Counter" );
        CancelInvoke( "DeltaCounter" );
    }


    private void Start()
    {
        InvokeRepeating( "Counter", 1, TimeCounter );
        InvokeRepeating( "DeltaCounter", 1, DeltaTimeCounter );
    }

    private void Counter()
    {
        _count += DeltaCount;
        TextCount.GetComponent<TMP_Text>().text = _count.ToString();
    }


    private void DeltaCounter()
    {
        if( TimeCounter > MinTimeCounter ) TimeCounter -= DeltaTime;
    }
}
