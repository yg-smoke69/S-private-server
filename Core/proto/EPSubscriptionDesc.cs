using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A8F")]
public class EPSubscriptionDesc
{
	[Token(Token = "0x400A654")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A655")]
	[FieldOffset(Offset = "0xC")]
	public uint rebate_id;

	[Token(Token = "0x400A656")]
	[FieldOffset(Offset = "0x10")]
	public uint subscription_bonus;

	[Token(Token = "0x400A657")]
	[FieldOffset(Offset = "0x14")]
	public uint subscription_extend_secs;

	[Token(Token = "0x400A658")]
	[FieldOffset(Offset = "0x18")]
	public uint subscription_protect_before_secs;

	[Token(Token = "0x400A659")]
	[FieldOffset(Offset = "0x1C")]
	public uint subscription_protect_after_secs;

	[Token(Token = "0x60080EC")]
	[Address(RVA = "0x309F6CC", Offset = "0x309F6CC", VA = "0x309F6CC")]
	public EPSubscriptionDesc()
	{
	}
}
