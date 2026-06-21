using UnityEngine;
using System.Collections;

public class LightFlicker : MonoBehaviour
{
    private Light myLight;

    public float minIntensity = 0.3f;
    public float maxIntensity = 2f;

    void Start()
    {
        myLight = GetComponent<Light>();
        StartCoroutine(Flicker());
    }

    IEnumerator Flicker()
    {
        while (true)
        {
            myLight.intensity = Random.Range(minIntensity, maxIntensity);

            yield return new WaitForSeconds(
                Random.Range(0.05f, 0.3f)
            );
        }
    }
}