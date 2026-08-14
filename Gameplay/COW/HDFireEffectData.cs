using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200014C")]
public class HDFireEffectData : CSVBaseData
{
	[Token(Token = "0x4000860")]
	[FieldOffset(Offset = "0x8")]
	public uint WeaponType;

	[Token(Token = "0x4000861")]
	[FieldOffset(Offset = "0xC")]
	public List<ResourceID> EffectList;

	[Token(Token = "0x4000862")]
	[FieldOffset(Offset = "0x10")]
	public List<float> EffectProbList;

	[Token(Token = "0x60007CB")]
	[Address(RVA = "0x1210750", Offset = "0x1210750", VA = "0x1210750")]
	public HDFireEffectData()
	{
	}

	[Token(Token = "0x60007CC")]
	[Address(RVA = "0x12107D4", Offset = "0x12107D4", VA = "0x12107D4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60007CD")]
	[Address(RVA = "0x1210838", Offset = "0x1210838", VA = "0x1210838", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
