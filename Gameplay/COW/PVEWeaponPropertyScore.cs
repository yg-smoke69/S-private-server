using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200020A")]
public class PVEWeaponPropertyScore : CSVBaseData, _Attribute
{
	[Token(Token = "0x4000C13")]
	[FieldOffset(Offset = "0x8")]
	public int[] Property;

	[Token(Token = "0x4000C14")]
	[FieldOffset(Offset = "0xC")]
	public int[] PropertyBlocks;

	[Token(Token = "0x4000C15")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x4000C16")]
	[FieldOffset(Offset = "0x14")]
	public uint SkinID;

	[Token(Token = "0x4000C17")]
	[FieldOffset(Offset = "0x18")]
	public uint WeaponLevel;

	[Token(Token = "0x6000A84")]
	[Address(RVA = "0x28CE840", Offset = "0x28CE840", VA = "0x28CE840")]
	public PVEWeaponPropertyScore()
	{
	}

	[Token(Token = "0x6000A85")]
	[Address(RVA = "0x28CE8C4", Offset = "0x28CE8C4", VA = "0x28CE8C4", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x6000A86")]
	[Address(RVA = "0x28CE91C", Offset = "0x28CE91C", VA = "0x28CE91C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A87")]
	[Address(RVA = "0x28CE980", Offset = "0x28CE980", VA = "0x28CE980", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
