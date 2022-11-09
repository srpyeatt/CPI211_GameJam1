using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileKnife : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject knife;
    [SerializeField] private Transform origin;
    [SerializeField] private float knifeSpeed = 50f;
    [SerializeField] private float cooldDown = 0.5f;
    private float timer = 0f;
    private bool canShoot = true;
    [SerializeField] private bool fullAuto = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((fullAuto ? Input.GetKeyDown(KeyCode.Space) : Input.GetKeyDown(KeyCode.Space)) && canShoot)
        {
            GameObject shot = Instantiate(knife, origin.position, Quaternion.Euler(0, 180, 90));
            shot.GetComponent<Rigidbody>().AddForce(origin.forward * knifeSpeed, ForceMode.Impulse); //punch it with force
            shot.GetComponent<Rigidbody>().AddTorque(transform.up * knifeSpeed);
            canShoot = false;
            timer = 0f;
        }

        if (!canShoot)
        {
            if (timer >= cooldDown)
                canShoot = true;

            timer += Time.deltaTime;
        }
    }
}
