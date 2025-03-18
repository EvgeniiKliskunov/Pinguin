using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Speed = 10;

    private void Update()
    {
        transform.position -= new Vector3( Speed * Time.deltaTime, 0, 0 );
        Destroy (gameObject, 10f);
    }

    public void setSpeed( float speed ) {
        Speed = speed;
    }
}
