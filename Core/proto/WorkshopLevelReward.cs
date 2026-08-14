using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001905")]
public class WorkshopLevelReward
{
	[Token(Token = "0x4009E8E")]
	[FieldOffset(Offset = "0x8")]
	public uint level;

	[Token(Token = "0x4009E8F")]
	[FieldOffset(Offset = "0xC")]
	public ExchangeChangeData award_data;

	[Token(Token = "0x6007F5E")]
	[Address(RVA = "0x33E670C", Offset = "0x33E670C", VA = "0x33E670C")]
	public WorkshopLevelReward()
	{
	}
}
