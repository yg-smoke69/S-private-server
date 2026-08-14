using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000798")]
public class GridGeneration : MonoBehaviour
{
	[Token(Token = "0x4004EC3")]
	[FieldOffset(Offset = "0xC")]
	public GameObject template;

	[Token(Token = "0x4004EC4")]
	[FieldOffset(Offset = "0x10")]
	public uint weight;

	[Token(Token = "0x4004EC5")]
	[FieldOffset(Offset = "0x14")]
	public uint height;

	[Token(Token = "0x4004EC6")]
	[FieldOffset(Offset = "0x18")]
	public float weightPad;

	[Token(Token = "0x4004EC7")]
	[FieldOffset(Offset = "0x1C")]
	public float heightPad;

	[Token(Token = "0x600309A")]
	[Address(RVA = "0x350B4AC", Offset = "0x350B4AC", VA = "0x350B4AC")]
	public GridGeneration()
	{
	}

	[Token(Token = "0x600309B")]
	[Address(RVA = "0x350B4DC", Offset = "0x350B4DC", VA = "0x350B4DC")]
	public void Start()
	{
	}
}
