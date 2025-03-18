using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed;
    public GameObject DeletePos;
    public GameObject CreatePos;

    private void FixedUpdate()
    {
        transform.position -= new Vector3( Speed * Time.deltaTime, 0, 0 );
        if( transform.position.x <= DeletePos.transform.position.x )
        {
            transform.position = new Vector3( CreatePos.transform.position.x, CreatePos.transform.position.y, 0 );
        }
    }
}
