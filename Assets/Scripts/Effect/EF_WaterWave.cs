using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EF_WaterWave : MonoBehaviour
{
    public Texture[] textures;
    private Material material;
    private int index = 0;
    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
        InvokeRepeating("ChangeTexture", 0, 0.08f);
    }
    void ChangeTexture()
    {
        material.mainTexture = textures[index];
        index = (index + 1) % textures.Length;
    }
}
