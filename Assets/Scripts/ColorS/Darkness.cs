using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Darkness : MonoBehaviour
{
    public float darkness = 0f;
    public float maxDarkness = 100f;
    public float decayRate;
    public float vignetteScaleFactor = 0.005f;
    public Volume globalVolume;
   
    Vignette vignette;
    ColorAdjustments colorAdjust;
    // Start is called before the first frame update
    //death event
    public delegate void DieDarkness();
    public static event DieDarkness onDieDarkness;


    void Start()
    {
        if (globalVolume.profile.TryGet<Vignette>( out vignette))
        {
            vignette.intensity.value =0f;
        }

        if (globalVolume.profile.TryGet<ColorAdjustments>(out colorAdjust))
        {
            colorAdjust.saturation.value = 0f;
        }
    }

    private void Update()
    {
        decay();
    }

    public void decay()
    {
        darkness += decayRate * Time.deltaTime;
        if (darkness >= maxDarkness)
        {
            darkness = maxDarkness;

            onDieDarkness();
            darkness = 0;
        }
        // update variables
        if (colorAdjust != null)
        {
            colorAdjust.saturation.value = Mathf.Clamp(-darkness,-100,100);
        }
        if (vignette!= null)
        {
            vignette.intensity.value = darkness * vignetteScaleFactor;
        }
    }
    private void OnEnable()
    {
        PaintProjectile.onBulletCollide += lightenUpBitch;
    }
    private void OnDisable()
    {
        PaintProjectile.onBulletCollide -= lightenUpBitch;
    }
    private void lightenUpBitch()
    {
        darkness = 0;
    }

    


}
