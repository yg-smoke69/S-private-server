using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DecalAtlas;

[Token(Token = "0x2003E94")]
public class DecalGroup : MonoBehaviour
{
	[Token(Token = "0x401A6E6")]
	[FieldOffset(Offset = "0xC")]
	protected DecalManager DecalManager;

	[Token(Token = "0x401A6E7")]
	[FieldOffset(Offset = "0x10")]
	public Texture2D MainTexAtlas;

	[Token(Token = "0x401A6E8")]
	[FieldOffset(Offset = "0x14")]
	public List<Vector4> RectList;

	[Token(Token = "0x401A6E9")]
	[FieldOffset(Offset = "0x18")]
	public int Granularities;

	[Token(Token = "0x401A6EA")]
	[FieldOffset(Offset = "0x1C")]
	public GranularityGrids PersistGridData;

	[Token(Token = "0x401A6EB")]
	[FieldOffset(Offset = "0x20")]
	protected Vector2[] PersistDecalPositions;

	[Token(Token = "0x401A6EC")]
	[FieldOffset(Offset = "0x24")]
	protected MeshRenderer _MeshRenderer;

	[Token(Token = "0x401A6ED")]
	[FieldOffset(Offset = "0x28")]
	protected MeshFilter _MeshFilter;

	[Token(Token = "0x401A6EE")]
	[FieldOffset(Offset = "0x2C")]
	protected Mesh m_mesh;

	[Token(Token = "0x401A6EF")]
	[FieldOffset(Offset = "0x30")]
	public Material m_mat;

	[Token(Token = "0x401A6F0")]
	[FieldOffset(Offset = "0x34")]
	protected int m_layerMask;

	[Token(Token = "0x401A6F1")]
	[FieldOffset(Offset = "0x38")]
	protected MaterialPropertyBlock m_matBlock;

	[Token(Token = "0x401A6F2")]
	[FieldOffset(Offset = "0x3C")]
	public float m_visiblePercent;

	[Token(Token = "0x401A6F3")]
	[FieldOffset(Offset = "0x40")]
	protected bool m_partVisible;

	[Token(Token = "0x601977D")]
	[Address(RVA = "0x23185D0", Offset = "0x23185D0", VA = "0x23185D0")]
	public DecalGroup()
	{
	}

	[Token(Token = "0x601977E")]
	[Address(RVA = "0x23185E0", Offset = "0x23185E0", VA = "0x23185E0", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x601977F")]
	[Address(RVA = "0x2318844", Offset = "0x2318844", VA = "0x2318844", Slot = "5")]
	protected virtual void UpdateDecalMesh(int swapDataIndex)
	{
	}

	[Token(Token = "0x6019780")]
	[Address(RVA = "0x23188CC", Offset = "0x23188CC", VA = "0x23188CC", Slot = "6")]
	public virtual void DrawDecalMesh()
	{
	}

	[Token(Token = "0x6019781")]
	[Address(RVA = "0x2318954", Offset = "0x2318954", VA = "0x2318954")]
	public void UpdateDecals()
	{
	}

	[Token(Token = "0x6019782")]
	[Address(RVA = "0x2318D68", Offset = "0x2318D68", VA = "0x2318D68")]
	private bool _UpdateGridCellVisibilityCheckEach(int swapDataIndex, ref GranularityDatum granularityDatum, ref GridForGranularity granularityGrid)
	{
		return default(bool);
	}

	[Token(Token = "0x6019783")]
	[Address(RVA = "0x2318BA4", Offset = "0x2318BA4", VA = "0x2318BA4")]
	private bool _UpdateGridCellVisibility(int swapDataIndex, ref GranularityDatum granularityDatum, ref GridForGranularity granularityGrid)
	{
		return default(bool);
	}
}
