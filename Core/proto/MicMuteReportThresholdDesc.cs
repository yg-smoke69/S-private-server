using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BF6")]
public class MicMuteReportThresholdDesc
{
	[Token(Token = "0x400B017")]
	[FieldOffset(Offset = "0x8")]
	public uint reported_threshold;

	[Token(Token = "0x400B018")]
	[FieldOffset(Offset = "0xC")]
	public uint add_mic_muted_time;

	[Token(Token = "0x6008251")]
	[Address(RVA = "0x30A8A0C", Offset = "0x30A8A0C", VA = "0x30A8A0C")]
	public MicMuteReportThresholdDesc()
	{
	}
}
