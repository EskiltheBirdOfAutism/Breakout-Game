using UnityEngine;

public class BlockCode : MonoBehaviour
{
    public ParticleSystem destroy;

    public GameObject text;

    public void OnCollisionEnter(Collision collision)
    {
        Instantiate(destroy, transform.position, Quaternion.identity);

        text.GetComponent<TextScript>().number++;

        Destroy(gameObject);
    }
}
