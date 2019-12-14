using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MeshFilter))] // always a mesh filter on the same object as script
public class MeshGen : MonoBehaviour


{
    // Start is called before the first frame update

  Mesh mesh; 
    private Vector3[] vertices; //arrey
    private int[] triangles;    // int arrey

    public int xSize = 20;
    public int zSize = 20;
    
    void Start()
    {
        mesh= new Mesh(); //creats new mesh object
        GetComponent<MeshFilter>().mesh = mesh; // gets the mesh filter

       
        UpdateMesh();
    }


    void CreatShape()

    {
        vertices = new Vector3[(xSize + 1) * (zSize+1)];
        
        int i = 0;

        for (int z = 0; z <= zSize; z++)
        {
            for (int x= 0; x<= xSize;  z++)
            {
                float y = Mathf.PerlinNoise(x * .3f, z * .3f) * 2f;
                    vertices[i] = new Vector3(x,y,z);
                    i++;
                    }
            
        }
        
        triangles = new int[xSize * zSize * 6];

        int vert = 0;
        int tris = 0;

        for (int z = 0; z < zSize; z++)
        {
            for (int x = 0; x < xSize; x++)

            {
                triangles = new int[6];

                triangles[tris +0] = vert+ 0;
                triangles[tris +1] = vert+ xSize + 1;
                triangles[tris +2] = vert+ 1;
                triangles[tris +3] = vert+ 1;
                triangles[tris+4] = vert+ xSize+1;
                triangles[tris+5] = vert+ xSize+2;

                vert++;
                tris += 6;
        }

            vert++;


        }

       
        
    }

    
   void UpdateMesh()
        {
            mesh.Clear();
            
            mesh.vertices = vertices;
            mesh.triangles = triangles;
            
            mesh.RecalculateNormals();
            
            }

    // Update is called once per frame
    void Update()
    {
        
    }
}
