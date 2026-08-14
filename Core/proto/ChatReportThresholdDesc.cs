using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BAE")]
public class ChatReportThresholdDesc
{
	[Token(Token = "0x400AE2E")]
	[FieldOffset(Offset = "0x8")]
	public uint reported_threshold;

	[Token(Token = "0x400AE2F")]
	[FieldOffset(Offset = "0xC")]
	public uint add_muted_time;

	[Token(Token = "0x6008209")]
	[Address(RVA = "0x309B304", Offset = "0x309B304", VA = "0x309B304")]
	public ChatReportThresholdDesc()
	{
	}
}
