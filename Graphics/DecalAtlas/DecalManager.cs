using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DecalAtlas;

[Token(Token = "0x2003E95")]
public class DecalManager : MonoBehaviour
{
	[Token(Token = "0x401A6F4")]
	[FieldOffset(Offset = "0xC")]
	public Rect TerrainRect;

	[Token(Token = "0x401A6F5")]
	[FieldOffset(Offset = "0x1C")]
	public GranularityDatum[] GranularityData;

	[Token(Token = "0x401A6F6")]
	[FieldOffset(Offset = "0x20")]
	public ProjectionDecalGroup[] ProjectionDecalGroups;

	[Token(Token = "0x401A6F7")]
	[FieldOffset(Offset = "0x24")]
	public QuadDecalGroup[] QuadDecalGroups;

	[NonSerialized]
	[Token(Token = "0x401A6F8")]
	[FieldOffset(Offset = "0x28")]
	public Dictionary<int, DecalDatum> EditorData;

	[Token(Token = "0x401A6F9")]
	[FieldOffset(Offset = "0x2C")]
	private int _SwapDataIndex;

	[NonSerialized]
	[Token(Token = "0x401A6FA")]
	[FieldOffset(Offset = "0x30")]
	public Vector2[] CameraTriangles;

	[Token(Token = "0x401A6FB")]
	[FieldOffset(Offset = "0x34")]
	public Camera _Camera;

	[Token(Token = "0x401A6FC")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 cameraPosition;

	[Token(Token = "0x401A6FD")]
	[FieldOffset(Offset = "0x44")]
	private Vector2 cameraForward;

	[Token(Token = "0x401A6FE")]
	[FieldOffset(Offset = "0x4C")]
	private float halfHorizontalCos;

	[Token(Token = "0x401A6FF")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 _LastCameraForward;

	[Token(Token = "0x401A700")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 _LastCameraPosition;

	[Token(Token = "0x401A701")]
	[FieldOffset(Offset = "0x68")]
	private readonly Vector3 _midDown;

	[Token(Token = "0x401A702")]
	[FieldOffset(Offset = "0x74")]
	private readonly List<Vector2> _3Points;

	[Token(Token = "0x401A703")]
	[FieldOffset(Offset = "0x78")]
	private readonly List<Vector2> _4Points;

	[Token(Token = "0x401A704")]
	[FieldOffset(Offset = "0x7C")]
	private List<Vector2> _Points;

	[Token(Token = "0x401A705")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 cameraForward3D;

	[Token(Token = "0x401A706")]
	[FieldOffset(Offset = "0x8C")]
	public bool camLookingDown;

	[Token(Token = "0x401A707")]
	[FieldOffset(Offset = "0x8D")]
	private bool camLookingBack;

	[Token(Token = "0x401A708")]
	[FieldOffset(Offset = "0x90")]
	private float leftRightScale;

	[Token(Token = "0x401A709")]
	[FieldOffset(Offset = "0x94")]
	private int distanceIndex;

	[Token(Token = "0x17001BD1")]
	public int SwapDataIndex
	{
		[Token(Token = "0x6019785")]
		[Address(RVA = "0x2318B9C", Offset = "0x2318B9C", VA = "0x2318B9C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6019784")]
	[Address(RVA = "0x231988C", Offset = "0x231988C", VA = "0x231988C")]
	public DecalManager()
	{
	}

	[Token(Token = "0x6019786")]
	[Address(RVA = "0x2319C84", Offset = "0x2319C84", VA = "0x2319C84")]
	private void Start()
	{
	}

	[Token(Token = "0x6019787")]
	[Address(RVA = "0x231A2C0", Offset = "0x231A2C0", VA = "0x231A2C0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6019788")]
	[Address(RVA = "0x231A620", Offset = "0x231A620", VA = "0x231A620")]
	private void _UpdateCameraData()
	{
	}

	[Token(Token = "0x6019789")]
	[Address(RVA = "0x231B2DC", Offset = "0x231B2DC", VA = "0x231B2DC")]
	public void _UpdateCellVisiblity()
	{
	}

	[Token(Token = "0x601978A")]
	[Address(RVA = "0x231C6BC", Offset = "0x231C6BC", VA = "0x231C6BC")]
	private void SortByCamDistance(ref List<Vector2Int> cells, int mid, Vector2Int camCoord)
	{
	}

	[Token(Token = "0x601978B")]
	[Address(RVA = "0x231C958", Offset = "0x231C958", VA = "0x231C958")]
	private int DistanceSqr(Vector2Int p0, Vector2Int p1)
	{
		return default(int);
	}

	[Token(Token = "0x601978C")]
	[Address(RVA = "0x2319670", Offset = "0x2319670", VA = "0x2319670")]
	public bool IsInTrapezoid(ref Vector2 position, ref Vector2 v0, ref Vector2 v1, ref Vector2 v2, ref Vector2 v3)
	{
		return default(bool);
	}

	[Token(Token = "0x601978D")]
	[Address(RVA = "0x2319544", Offset = "0x2319544", VA = "0x2319544")]
	public bool IsGOVisible(Vector2 point)
	{
		return default(bool);
	}
}
