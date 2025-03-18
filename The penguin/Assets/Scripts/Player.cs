using TMPro; 
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float JumpPower = 4;
    private bool _isGround = false;

    public GameObject TextCount;
    private int _count = 0;

    public GameObject TextFishs;
    private int _fishs = 0;

    public GameObject GameOver;
   
    public GameObject GameOverCount;
    public GameObject GameOverFishs;

    public ParticleSystem Snow;

    public void Jump()
    {
        if ( _isGround ) {
            GetComponent<Rigidbody2D>().linearVelocity = new Vector3( 0, JumpPower, 0 );
            _isGround = false;
            Snow.Stop();
        }
    }


    private void Update()
    {
        if( Input.GetKey( KeyCode.Space )) {
            Jump();
        }
    }

    private void OnTriggerEnter2D( Collider2D Coll )
    {
        if( Coll.gameObject.tag == "Counter" ) {
            _count++;
        }

        if( Coll.gameObject.tag == "Fish" ) {
            Destroy( Coll.gameObject );
            GetComponent<Animator>().Play( "Eat" );
            _fishs++;
            TextFishs.GetComponent<TMP_Text>().text = _fishs.ToString();
        }
    }

    private void OnCollisionEnter2D( Collision2D Coll )
    {
        if( Coll.gameObject.tag == "Ground" ) {
            _isGround = true;
            Snow.Play();
        }

        if( Coll.gameObject.tag == "Enemy" ) {
            if( PlayerPrefs.HasKey( "Fishs" )) PlayerPrefs.SetInt( "Fishs", PlayerPrefs.GetInt( "Fishs" ) + _fishs);
            else PlayerPrefs.SetInt( "Fishs", _fishs);

            GameOverFishs.GetComponent<TMP_Text>().text = PlayerPrefs.GetInt( "Fishs" ).ToString();
            GameOverCount.GetComponent<TMP_Text>().text = _count.ToString();

            GameOver.SetActive( true );
            Time.timeScale = 0;
        }
    }
}
