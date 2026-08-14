using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200413A")]
public class UICustomMeshCollider : MonoBehaviour
{
	[Token(Token = "0x401B611")]
	[FieldOffset(Offset = "0xC")]
	public string MeshName;

	[Token(Token = "0x401B612")]
	[FieldOffset(Offset = "0x10")]
	public Mesh MeshRef;

	[Token(Token = "0x401B613")]
	[FieldOffset(Offset = "0x14")]
	public bool SectorShape;

	[Token(Token = "0x401B614")]
	[FieldOffset(Offset = "0x18")]
	public float Radius;

	[Token(Token = "0x401B615")]
	[FieldOffset(Offset = "0x1C")]
	public float InnerRadius;

	[Token(Token = "0x401B616")]
	[FieldOffset(Offset = "0x20")]
	public float AngleDegree;

	[Token(Token = "0x401B617")]
	[FieldOffset(Offset = "0x24")]
	public uint Segments;

	[Token(Token = "0x401B618")]
	[FieldOffset(Offset = "0x28")]
	public float AngleStart;

	[Token(Token = "0x401B619")]
	[FieldOffset(Offset = "0x2C")]
	public float OffsetX;

	[Token(Token = "0x401B61A")]
	[FieldOffset(Offset = "0x30")]
	public float OffsetY;

	[Token(Token = "0x401B61B")]
	[FieldOffset(Offset = "0x34")]
	public uint Size;

	[Token(Token = "0x401B61C")]
	[FieldOffset(Offset = "0x38")]
	public Pos[] Vertices;

	[Token(Token = "0x401B61D")]
	[FieldOffset(Offset = "0x3C")]
	private MeshCollider m_Collider;

	[Token(Token = "0x401B61E")]
	[FieldOffset(Offset = "0x40")]
	private Mesh m_Mesh;

	[Token(Token = "0x17001D5B")]
	public Mesh MMesh
	{
		[Token(Token = "0x601AA6E")]
		[Address(RVA = "0x146ACE4", Offset = "0x146ACE4", VA = "0x146ACE4")]
		get
		{
			return null;
		}
		[Token(Token = "0x601AA6F")]
		[Address(RVA = "0x146ACEC", Offset = "0x146ACEC", VA = "0x146ACEC")]
		set
		{
		}
	}

	[Token(Token = "0x601AA6D")]
	[Address(RVA = "0x146AC0C", Offset = "0x146AC0C", VA = "0x146AC0C")]
	public UICustomMeshCollider()
	{
	}

	[Token(Token = "0x601AA70")]
	[Address(RVA = "0x146ACF4", Offset = "0x146ACF4", VA = "0x146ACF4")]
	private void Start()
	{
	}
}
