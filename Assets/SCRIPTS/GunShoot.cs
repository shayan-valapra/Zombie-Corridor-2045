using UnityEngine;

public class GunShoot : MonoBehaviour
{
    public float range = 100f;
    public Camera fpsCamera;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(
            fpsCamera.transform.position,
            fpsCamera.transform.forward,
            out hit,
            range))
        {
            Debug.Log("Hit: " + hit.transform.name);
        }
    }
}