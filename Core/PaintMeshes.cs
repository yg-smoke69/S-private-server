using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003F9A")]
public class PaintMeshes : MonoBehaviour
{
	[Token(Token = "0x401ACB1")]
	[FieldOffset(Offset = "0xC")]
	public float radius;

	[Token(Token = "0x401ACB2")]
	[FieldOffset(Offset = "0x10")]
	public float offset;

	[Token(Token = "0x401ACB3")]
	[FieldOffset(Offset = "0x14")]
	public float density;

	[Token(Token = "0x401ACB4")]
	[FieldOffset(Offset = "0x18")]
	public float slopeInfluence;

	[Token(Token = "0x401ACB5")]
	[FieldOffset(Offset = "0x1C")]
	public float randomRotation;

	[Token(Token = "0x401ACB6")]
	[FieldOffset(Offset = "0x20")]
	public bool slopeCorrection;

	[Token(Token = "0x401ACB7")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 randomScaleRange;

	[Token(Token = "0x401ACB8")]
	[FieldOffset(Offset = "0x2C")]
	private float nextFeasibleStrokeTime;

	[Token(Token = "0x401ACB9")]
	[FieldOffset(Offset = "0x30")]
	public List<GameObject> meshes;

	[Token(Token = "0x401ACBA")]
	[FieldOffset(Offset = "0x34")]
	protected List<Transform> paintedMeshes;

	[Token(Token = "0x401ACBB")]
	[FieldOffset(Offset = "0x38")]
	protected List<Transform> paintedMeshesInsideBrushArea;

	[Token(Token = "0x17001C46")]
	public int meshCount
	{
		[Token(Token = "0x6019E11")]
		[Address(RVA = "0x1C79B64", Offset = "0x1C79B64", VA = "0x1C79B64")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001C47")]
	public virtual bool HasMesh
	{
		[Token(Token = "0x6019E12")]
		[Address(RVA = "0x1C79C6C", Offset = "0x1C79C6C", VA = "0x1C79C6C", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6019E10")]
	[Address(RVA = "0x1C79950", Offset = "0x1C79950", VA = "0x1C79950")]
	public PaintMeshes()
	{
	}
}
