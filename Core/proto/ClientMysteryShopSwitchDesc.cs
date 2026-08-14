using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001754")]
public class ClientMysteryShopSwitchDesc
{
	[Token(Token = "0x40099F6")]
	[FieldOffset(Offset = "0x8")]
	public uint pool_id;

	[Token(Token = "0x40099F7")]
	[FieldOffset(Offset = "0xC")]
	public uint unlock_amount;

	[Token(Token = "0x40099F8")]
	[FieldOffset(Offset = "0x10")]
	public uint switch_amount;

	[Token(Token = "0x40099F9")]
	[FieldOffset(Offset = "0x14")]
	public string shop_cdn;

	[Token(Token = "0x40099FA")]
	[FieldOffset(Offset = "0x18")]
	public string switch_cdn;

	[Token(Token = "0x40099FB")]
	[FieldOffset(Offset = "0x1C")]
	public uint cost_gems;

	[Token(Token = "0x40099FC")]
	[FieldOffset(Offset = "0x20")]
	public string pool_center_cdn;

	[Token(Token = "0x6007DAE")]
	[Address(RVA = "0x309C814", Offset = "0x309C814", VA = "0x309C814")]
	public ClientMysteryShopSwitchDesc()
	{
	}
}
