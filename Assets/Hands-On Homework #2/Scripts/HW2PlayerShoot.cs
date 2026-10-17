using System;
using UnityEngine;

public class HW2PlayerShoot : MonoBehaviour
{
    public GameObject preFab;
    public GameObject preFab2;
    public Transform bulletTrash;
    public Transform bulletSpawn;
    public Transform bulletTrash2;
    public Transform bulletSpawn2;

    private const float Timer = 0.5f;
    private float _currentTime = 0.5f;
    private bool _canShoot = true;
    private void Update()
    {
        TimerMethod();
        Shoot();
        Shoot2();
        TimerMethod2();
    }

    private void TimerMethod()
    {
        if (!_canShoot)
        {
            _currentTime -= Time.deltaTime;

            if (_currentTime < 0)
            {
                _canShoot = true;
                _currentTime = Timer;
            }
        }
    }

    private void Shoot ()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && _canShoot)
        {
            GameObject bullet = Instantiate(preFab, bulletSpawn.position, Quaternion.identity);

            bullet.transform.SetParent(bulletTrash);

            _canShoot = false;
        }
    }

    private void TimerMethod2()
    {
        if (!_canShoot)
        {
            _currentTime = Time.deltaTime;

            if (_currentTime < 0)
            {
                _canShoot = true;
                _currentTime = Timer;
            }
        }
    }
    private void Shoot2()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) && _canShoot)
        {
            GameObject bullet2 = Instantiate(preFab2, bulletSpawn2.position, Quaternion.identity);

            bullet2.transform.SetParent(bulletTrash2);

            _canShoot = false;
        }
    }
}
