using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000E0")]
public class LootBoxData : CSVBaseData, _Attribute
{
	[Token(Token = "0x400054C")]
	[FieldOffset(Offset = "0x8")]
	public uint iID;

	[Token(Token = "0x400054D")]
	[FieldOffset(Offset = "0xC")]
	public uint sortId;

	[Token(Token = "0x400054E")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID briefRes;

	[Token(Token = "0x400054F")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID previewRes;

	[Token(Token = "0x4000550")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID inGameRes;

	[Token(Token = "0x4000551")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID inGameTexture;

	[Token(Token = "0x4000552")]
	[FieldOffset(Offset = "0x20")]
	public ESourceType sourceTypeKey;

	[Token(Token = "0x4000553")]
	[FieldOffset(Offset = "0x21")]
	public bool IsWithEffect;

	[Token(Token = "0x60005DE")]
	[Address(RVA = "0x152EBD4", Offset = "0x152EBD4", VA = "0x152EBD4")]
	public LootBoxData()
	{
	}

	[Token(Token = "0x60005DF")]
	[Address(RVA = "0x152ECC4", Offset = "0x152ECC4", VA = "0x152ECC4", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x60005E0")]
	[Address(RVA = "0x152ED1C", Offset = "0x152ED1C", VA = "0x152ED1C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60005E1")]
	[Address(RVA = "0x152ED80", Offset = "0x152ED80", VA = "0x152ED80", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
