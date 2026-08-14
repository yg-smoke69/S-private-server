using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200013E")]
public class FullScreenPreviewData : CSVBaseData
{
	[Token(Token = "0x400080C")]
	[FieldOffset(Offset = "0x8")]
	public uint ItemID;

	[Token(Token = "0x400080D")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 Position;

	[Token(Token = "0x400080E")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 Rotation;

	[Token(Token = "0x400080F")]
	[FieldOffset(Offset = "0x24")]
	public float GlassPosY;

	[Token(Token = "0x600079A")]
	[Address(RVA = "0x104FE2C", Offset = "0x104FE2C", VA = "0x104FE2C")]
	public FullScreenPreviewData()
	{
	}

	[Token(Token = "0x600079B")]
	[Address(RVA = "0x104FEB0", Offset = "0x104FEB0", VA = "0x104FEB0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600079C")]
	[Address(RVA = "0x104FF14", Offset = "0x104FF14", VA = "0x104FF14", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
