using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private int damage;

    private void OnCollisionEnter(Collision collision)
    {
        Stats other = collision.gameObject.GetComponent<Stats>();

        if (other != null)
        {
            other.TakeDamage(this.damage);
        }
    }
}
