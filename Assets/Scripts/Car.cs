using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public GameObject notice;

    public bool isParking;

    private void Awake()
    {
        notice.SetActive(false);

        isParking = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision != null && collision.gameObject.CompareTag("Not"))
        {
            isParking = false;
            notice.SetActive(true);
        }
        else if (collision != null && collision.gameObject.CompareTag("Parking"))
        {
            isParking = true;
            notice.SetActive(false);
        }
    }
}
