using UnityEngine;

public class CameraShake : MonoBehaviour
{
    // Camera Information
    public Transform cameraTransform;
    private Vector3 orignalCameraPos;

    // Shake Parameters
    public float shakeDuration = 2f;
    public float shakeAmount = 0.7f;

    private bool canShake = false;
    private float shakeTimer;

 

    // Start is called before the first frame update
    void Start()
    {
        orignalCameraPos = cameraTransform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {

        if (canShake)
        {
            StartCameraShakeEffect();
        }
    }

    public void ShakeCamera()
    {
        canShake = true;
        shakeTimer = shakeDuration;
    }

    public void StartCameraShakeEffect()
    {
        if (shakeTimer > 0)
        {
            cameraTransform.localPosition = orignalCameraPos + Random.insideUnitSphere * shakeAmount;
            shakeTimer -= Time.deltaTime;
        }
        else
        {
            shakeTimer = 0f;
            cameraTransform.position = orignalCameraPos;
            canShake = false;
        }
    }

}