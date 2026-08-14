using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002D09")]
public class BaseBundleItemInfo
{
	[Token(Token = "0x40112D0")]
	[FieldOffset(Offset = "0x8")]
	public uint award_id;

	[Token(Token = "0x40112D1")]
	[FieldOffset(Offset = "0xC")]
	public bool is_preview;

	[Token(Token = "0x40112D2")]
	[FieldOffset(Offset = "0x10")]
	public uint preview_avatar;

	[Token(Token = "0x6012D45")]
	[Address(RVA = "0x2E51378", Offset = "0x2E51378", VA = "0x2E51378")]
	public BaseBundleItemInfo(BundleShowData bundleitem)
	{
	}

	[Token(Token = "0x6012D46")]
	[Address(RVA = "0x2E513E8", Offset = "0x2E513E8", VA = "0x2E513E8")]
	public BaseBundleItemInfo(TreasureBoxShowData bundleitem)
	{
	}
}
