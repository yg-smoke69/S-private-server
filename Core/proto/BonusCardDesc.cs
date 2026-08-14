using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019AC")]
public class BonusCardDesc
{
	[Token(Token = "0x400A0F8")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A0F9")]
	[FieldOffset(Offset = "0xC")]
	public string name;

	[Token(Token = "0x400A0FA")]
	[FieldOffset(Offset = "0x10")]
	public EInventory.BonusCardType card_type;

	[Token(Token = "0x400A0FB")]
	[FieldOffset(Offset = "0x14")]
	public uint gold_factor;

	[Token(Token = "0x400A0FC")]
	[FieldOffset(Offset = "0x18")]
	public uint exp_factor;

	[Token(Token = "0x400A0FD")]
	[FieldOffset(Offset = "0x1C")]
	public uint ep_debris_factor;

	[Token(Token = "0x400A0FE")]
	[FieldOffset(Offset = "0x20")]
	public uint mentoring_intimacy_factor;

	[Token(Token = "0x6008003")]
	[Address(RVA = "0x317C814", Offset = "0x317C814", VA = "0x317C814")]
	public BonusCardDesc()
	{
	}
}
