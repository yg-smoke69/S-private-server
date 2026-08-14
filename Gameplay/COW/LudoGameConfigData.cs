using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000191")]
public class LudoGameConfigData : CSVBaseData
{
	[Token(Token = "0x40009AA")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x40009AB")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID chess_res;

	[Token(Token = "0x40009AC")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID chessAction_res;

	[Token(Token = "0x40009AD")]
	[FieldOffset(Offset = "0x14")]
	public float walkspeedscale;

	[Token(Token = "0x40009AE")]
	[FieldOffset(Offset = "0x18")]
	public Color chessColor;

	[Token(Token = "0x40009AF")]
	[FieldOffset(Offset = "0x28")]
	public ResourceID chessHalo_res;

	[Token(Token = "0x40009B0")]
	[FieldOffset(Offset = "0x2C")]
	public ResourceID chessSelect_res;

	[Token(Token = "0x40009B1")]
	[FieldOffset(Offset = "0x30")]
	public ResourceID chessArrow_res;

	[Token(Token = "0x40009B2")]
	[FieldOffset(Offset = "0x34")]
	public float chessScale;

	[Token(Token = "0x60008DD")]
	[Address(RVA = "0x153016C", Offset = "0x153016C", VA = "0x153016C")]
	public LudoGameConfigData()
	{
	}

	[Token(Token = "0x60008DE")]
	[Address(RVA = "0x15302A8", Offset = "0x15302A8", VA = "0x15302A8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60008DF")]
	[Address(RVA = "0x153030C", Offset = "0x153030C", VA = "0x153030C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
