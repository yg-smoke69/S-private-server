using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000BEA")]
public class BEPopWndItemData
{
	[Token(Token = "0x4006307")]
	[FieldOffset(Offset = "0x8")]
	public int itemId;

	[Token(Token = "0x4006308")]
	[FieldOffset(Offset = "0xC")]
	public string name;

	[Token(Token = "0x4006309")]
	[FieldOffset(Offset = "0x10")]
	public string spriteName;

	[Token(Token = "0x400630A")]
	[FieldOffset(Offset = "0x14")]
	public string groupName;

	[Token(Token = "0x6005A26")]
	[Address(RVA = "0x2E4B9B4", Offset = "0x2E4B9B4", VA = "0x2E4B9B4")]
	public BEPopWndItemData()
	{
	}
}
