using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000B9")]
public class ClothesUpData : CSVBaseData, _Attribute
{
	[Token(Token = "0x4000480")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000481")]
	[FieldOffset(Offset = "0xC")]
	public uint ClothesID;

	[Token(Token = "0x4000482")]
	[FieldOffset(Offset = "0x10")]
	public uint EffectsTriggerID;

	[Token(Token = "0x4000483")]
	[FieldOffset(Offset = "0x14")]
	public uint ClothesUpID;

	[Token(Token = "0x4000484")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID EffectIDM;

	[Token(Token = "0x4000485")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID EffectIDF;

	[Token(Token = "0x600053F")]
	[Address(RVA = "0x172EC50", Offset = "0x172EC50", VA = "0x172EC50")]
	public ClothesUpData()
	{
	}

	[Token(Token = "0x6000540")]
	[Address(RVA = "0x172ECD4", Offset = "0x172ECD4", VA = "0x172ECD4", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x6000541")]
	[Address(RVA = "0x172ED2C", Offset = "0x172ED2C", VA = "0x172ED2C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000542")]
	[Address(RVA = "0x172ED90", Offset = "0x172ED90", VA = "0x172ED90", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
