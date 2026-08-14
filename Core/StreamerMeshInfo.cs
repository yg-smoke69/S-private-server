using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D24")]
public class StreamerMeshInfo : StreamerObjectRefInfo
{
	[Token(Token = "0x4019EF8")]
	[FieldOffset(Offset = "0xC")]
	public uint MeshIndex;

	[Token(Token = "0x4019EF9")]
	[FieldOffset(Offset = "0x10")]
	public Mesh OwnedMesh;

	[Token(Token = "0x601877C")]
	[Address(RVA = "0x21C5228", Offset = "0x21C5228", VA = "0x21C5228")]
	public StreamerMeshInfo()
	{
	}

	[Token(Token = "0x601877D")]
	[Address(RVA = "0x21DB500", Offset = "0x21DB500", VA = "0x21DB500", Slot = "4")]
	public override void UnLoadAsset(SceneStreamerInfoHelper helper)
	{
	}
}
