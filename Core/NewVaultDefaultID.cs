using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x20001BF")]
public class NewVaultDefaultID : CSVBaseData, _Attribute
{
	[Token(Token = "0x4000ACE")]
	[FieldOffset(Offset = "0x8")]
	public uint ItemID;

	[Token(Token = "0x600096D")]
	[Address(RVA = "0x1C72D04", Offset = "0x1C72D04", VA = "0x1C72D04")]
	public NewVaultDefaultID()
	{
	}

	[Token(Token = "0x600096E")]
	[Address(RVA = "0x1C72D88", Offset = "0x1C72D88", VA = "0x1C72D88", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600096F")]
	[Address(RVA = "0x1C72D94", Offset = "0x1C72D94", VA = "0x1C72D94", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000970")]
	[Address(RVA = "0x1C72E48", Offset = "0x1C72E48", VA = "0x1C72E48", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}
}
