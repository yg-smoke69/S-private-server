using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000130")]
public class FFWS03WeaponListData : CSVBaseData
{
	[Token(Token = "0x40007CB")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x40007CC")]
	[FieldOffset(Offset = "0xC")]
	public string Key;

	[Token(Token = "0x600075A")]
	[Address(RVA = "0x2303308", Offset = "0x2303308", VA = "0x2303308")]
	public FFWS03WeaponListData()
	{
	}

	[Token(Token = "0x600075B")]
	[Address(RVA = "0x230338C", Offset = "0x230338C", VA = "0x230338C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x600075C")]
	[Address(RVA = "0x23034D4", Offset = "0x23034D4", VA = "0x23034D4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}
}
