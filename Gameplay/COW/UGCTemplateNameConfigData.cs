using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001A3")]
public class UGCTemplateNameConfigData : CSVBaseData
{
	[Token(Token = "0x4000A35")]
	[FieldOffset(Offset = "0x8")]
	public uint TemplateID;

	[Token(Token = "0x4000A36")]
	[FieldOffset(Offset = "0xC")]
	public string TemplateName;

	[Token(Token = "0x6000916")]
	[Address(RVA = "0x29F5A90", Offset = "0x29F5A90", VA = "0x29F5A90")]
	public UGCTemplateNameConfigData()
	{
	}

	[Token(Token = "0x6000917")]
	[Address(RVA = "0x29F5B14", Offset = "0x29F5B14", VA = "0x29F5B14", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000918")]
	[Address(RVA = "0x29F5B78", Offset = "0x29F5B78", VA = "0x29F5B78", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
