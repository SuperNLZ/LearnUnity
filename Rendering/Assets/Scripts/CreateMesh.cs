using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMesh : MonoBehaviour
{
	private MeshFilter filter;
	private Mesh mesh;

	// Use this for initialization
	void Start()
	{
		// 获取GameObject的Filter组件
		filter = GetComponent<MeshFilter>();
		// 并新建一个mesh给它
		mesh = new Mesh();
		filter.mesh = mesh;

		// 初始化网格
		InitMesh();
	}

	// Update is called once per frame
	void Update()
	{

	}

	/// <summary>
	/// Inits the mesh.
	/// </summary>
	void InitMesh()
	{
		mesh.name = "MyMesh";

		// 为网格创建顶点数组
		Vector3[] vertices = new Vector3[4]{
			new Vector3(1, 1, 0),
			new Vector3(-1, 1, 0),
			new Vector3(1, -1, 0),
			new Vector3(-1, -1, 0)
		};

		mesh.vertices = vertices;

		// 通过顶点为网格创建三角形
		int[] triangles = new int[2 * 3]{
			0, 3, 1, 0, 2, 3
		};

		mesh.triangles = triangles;

		// 为mesh设置纹理贴图坐标
		Vector2[] uv = new Vector2[4]{
			new Vector2(1, 1),
			new Vector2(0, 1),
			new Vector2(1, 0),
			new Vector2(0, 0)
		};

		mesh.uv = uv;
	}
}
