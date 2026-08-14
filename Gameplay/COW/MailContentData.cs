using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000195")]
public class MailContentData : CSVBaseData
{
	[Token(Token = "0x40009BD")]
	[FieldOffset(Offset = "0x8")]
	public int ID;

	[Token(Token = "0x40009BE")]
	[FieldOffset(Offset = "0xC")]
	public string Title;

	[Token(Token = "0x40009BF")]
	[FieldOffset(Offset = "0x10")]
	public string Content;

	[Token(Token = "0x60008EC")]
	[Address(RVA = "0x1532318", Offset = "0x1532318", VA = "0x1532318")]
	public MailContentData()
	{
	}

	[Token(Token = "0x60008ED")]
	[Address(RVA = "0x153239C", Offset = "0x153239C", VA = "0x153239C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x60008EE")]
	[Address(RVA = "0x1532568", Offset = "0x1532568", VA = "0x1532568", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}
}
