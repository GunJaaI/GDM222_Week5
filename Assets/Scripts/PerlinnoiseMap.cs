using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinnoiseMap : MonoBehaviour
{
    [SerializeField]
    private int gridCount; // Count Vertex
    [SerializeField]
    private float magnitude; // roll high 0-1
    [SerializeField]
    private float maxSample;
    /*
    [SerializableField]
    private Tranform origin;
    */
    private Material standardMaterial;
    void Awake() {
        standardMaterial = new Material(Shader.Find("Unlit/Color"));
    }
    void Start() {
        TerrainGen.Generate(this.gridCount,
                            this.magnitude,
                            this.maxSample,
                            this.standardMaterial);
    }
}
