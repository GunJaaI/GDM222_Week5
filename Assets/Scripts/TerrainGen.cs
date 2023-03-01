using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGen {
    public static GameObject Generate(int gridCount,
                                      float magnitude,
                                      float maxSample,
                                      Material material ) {
        GameObject cubeInstance = new GameObject();

        MeshRenderer meshRenderer = cubeInstance.AddComponent<MeshRenderer>();
        meshRenderer.sharedMaterial = material;

        MeshFilter meshFilter = cubeInstance.AddComponent<MeshFilter>();

        Mesh mesh = new Mesh();

        Vector3[] vertices = new Vector3[gridCount * gridCount];
        // new Vector3(-size/2, 0, size/2),
            for (int i=0; i < gridCount; i++) {
                for(int j=0; j < gridCount; j++) {
                    vertices[i * gridCount + j] = new Vector3(i,0,j);
                }
            }
        mesh.vertices = vertices;

        int[] tris = new int[(gridCount - 1) * (gridCount - 1) * 2 * 3];
        // 4, 7, 6
            for (int i=0; i < gridCount - 1; i++) {
                for(int j=0; j < gridCount - 1; j++) {
                    tris[i * gridCount + j] = i * gridCount + j ;
                    tris[i * gridCount + 1] = i * gridCount + j + 1;
                    tris[i * gridCount + 2] = (i + 1) * gridCount + j;
                    tris[i * gridCount + 3] = (i + 1) * gridCount + j;
                    tris[i * gridCount + 4] = i * gridCount + j + 1;
                    tris[i * gridCount + 5] = (i + 1) * gridCount + j + 1;
                }
            }
        mesh.triangles = tris;

        mesh.RecalculateNormals();

        meshFilter.mesh = mesh;

        return cubeInstance;
    }
}
