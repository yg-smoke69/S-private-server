using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000E8")]
public class WeaponPropertyScore : CSVBaseData, _Attribute
{
	[Token(Token = "0x40005C7")]
	[FieldOffset(Offset = "0x8")]
	public int[] Property;

	[Token(Token = "0x40005C8")]
	[FieldOffset(Offset = "0xC")]
	public uint WeaponID;

	[Token(Token = "0x60005FD")]
	[Address(RVA = "0x21A4380", Offset = "0x21A4380", VA = "0x21A4380")]
	public WeaponPropertyScore()
	{
	}

	[Token(Token = "0x60005FE")]
	[Address(RVA = "0x21A4404", Offset = "0x21A4404", VA = "0x21A4404", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x60005FF")]
	[Address(RVA = "0x21A445C", Offset = "0x21A445C", VA = "0x21A445C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000600")]
	[Address(RVA = "0x21A44C0", Offset = "0x21A44C0", VA = "0x21A44C0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
