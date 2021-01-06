using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Header("金幣音效")]
    public AudioClip soundCoin;

    private AudioSource aud;
    private void Awake()

       
    {
       aud = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
        
    {

        if (collision.gameObject.name == "Drawers")
        {

           aud.PlayOneShot(soundCoin, 1.5f);

        }

    }






}
