using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000268")]
public class WeaponTagInfoData : CSVBaseData
{
	[Token(Token = "0x4000EAD")]
	[FieldOffset(Offset = "0x8")]
	public int TagID;

	[Token(Token = "0x4000EAE")]
	[FieldOffset(Offset = "0xC")]
	public Color TagColor;

	[Token(Token = "0x4000EAF")]
	[FieldOffset(Offset = "0x1C")]
	public string TagKey;

	[Token(Token = "0x4000EB0")]
	[FieldOffset(Offset = "0x20")]
	public string TagDesc;

	[Token(Token = "0x6000BD6")]
	[Address(RVA = "0x2A6BE70", Offset = "0x2A6BE70", VA = "0x2A6BE70")]
	public WeaponTagInfoData()
	{
	}

	[Token(Token = "0x6000BD7")]
	[Address(RVA = "0x2A6BEF4", Offset = "0x2A6BEF4", VA = "0x2A6BEF4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000BD8")]
	[Address(RVA = "0x2A6BF00", Offset = "0x2A6BF00", VA = "0x2A6BF00", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
