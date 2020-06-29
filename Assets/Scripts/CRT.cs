using System.Collections;
using UnityEngine;

[ExecuteInEditMode]
public class CRT : MonoBehaviour
{

    public float scanlineIntensity = 100;
    public int scanlineWidth = 1;
    //	public Color scanlineColor = Color.black;
    //	public bool tVBulge = true;
    private Material material_Displacement;
    private Material material_Scanlines;

    void Awake()
    {
        material_Scanlines = new Material(Shader.Find("Hidden/Scanlines"));
    }

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        material_Scanlines.SetFloat("_Intensity", scanlineIntensity * 0.01f);
        material_Scanlines.SetFloat("_ValueX", scanlineWidth);

        Graphics.Blit(source, destination, material_Scanlines);

    }
}