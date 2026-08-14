using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AEE")]
public class GoogleRewardsDesc
{
	[Token(Token = "0x400A948")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A949")]
	[FieldOffset(Offset = "0xC")]
	public string region;

	[Token(Token = "0x400A94A")]
	[FieldOffset(Offset = "0x10")]
	public uint is_paid;

	[Token(Token = "0x400A94B")]
	[FieldOffset(Offset = "0x14")]
	public uint is_ep_unlock;

	[Token(Token = "0x400A94C")]
	[FieldOffset(Offset = "0x18")]
	public uint action_type;

	[Token(Token = "0x400A94D")]
	[FieldOffset(Offset = "0x1C")]
	public string task_desc;

	[Token(Token = "0x400A94E")]
	[FieldOffset(Offset = "0x20")]
	public string reward_desc;

	[Token(Token = "0x6008149")]
	[Address(RVA = "0x30A2BEC", Offset = "0x30A2BEC", VA = "0x30A2BEC")]
	public GoogleRewardsDesc()
	{
	}
}
