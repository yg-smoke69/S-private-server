using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B1C")]
public class RetentionPushNotificationDesc
{
	[Token(Token = "0x400AA6B")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400AA6C")]
	[FieldOffset(Offset = "0xC")]
	public uint status;

	[Token(Token = "0x400AA6D")]
	[FieldOffset(Offset = "0x10")]
	public uint notify_time;

	[Token(Token = "0x400AA6E")]
	[FieldOffset(Offset = "0x14")]
	public AwardDesc Award;

	[Token(Token = "0x6008177")]
	[Address(RVA = "0x33E1960", Offset = "0x33E1960", VA = "0x33E1960")]
	public RetentionPushNotificationDesc()
	{
	}
}
