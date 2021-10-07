using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public LayerMask playerLayer;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        GameObject other = collider.gameObject;

        if(playerLayer.Contains(other))
        {
            Debug.Log("colliusion iwhjt choijn");
            Destroy(gameObject);

            Scorekeeper.Instance.IncrementScore(other);
        }
    }
}
