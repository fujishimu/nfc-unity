using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class FadeMng : MonoBehaviour
{

    // Materialを保持するようにする
    [SerializeField]
    private Material _mat;

    private int winW = Screen.width;
    private int winH = Screen.height;

    private void Start()
    {
        transform.position = new Vector3(winW / 2, winH / 2);

        var mesh = new Mesh();
        mesh.vertices = new Vector3[] {
            new Vector3 (winW, winH),
            new Vector3 (winW, -winH),
            new Vector3 (-winW, -winH),
            new Vector3 (-winW, winH)
        };
        mesh.triangles = new int[] {
            0, 1, 2,
            0, 2, 3,
        };

        var filter = GetComponent<MeshFilter>();
        filter.sharedMesh = mesh;

        // MeshRendererからMaterialにアクセスし、Materialをセットする
        var renderer = GetComponent<MeshRenderer>();
        renderer.material = _mat;
    }
}