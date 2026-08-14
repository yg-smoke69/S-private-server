using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014DF")]
public class BoybandBSuitsRewardsInfo
{
	[Token(Token = "0x4009017")]
	[FieldOffset(Offset = "0x8")]
	public uint suit_serial;

	[Token(Token = "0x4009018")]
	[FieldOffset(Offset = "0xC")]
	public uint reward_item_id;

	[Token(Token = "0x6007B34")]
	[Address(RVA = "0x317D378", Offset = "0x317D378", VA = "0x317D378")]
	public BoybandBSuitsRewardsInfo()
	{
	}
}
