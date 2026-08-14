using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BF7")]
public class MicMuteSwitchDesc
{
	[Token(Token = "0x400B019")]
	[FieldOffset(Offset = "0x8")]
	public bool enable_api_data;

	[Token(Token = "0x400B01A")]
	[FieldOffset(Offset = "0x9")]
	public bool mic_mute_switch;

	[Token(Token = "0x6008252")]
	[Address(RVA = "0x30A8A14", Offset = "0x30A8A14", VA = "0x30A8A14")]
	public MicMuteSwitchDesc()
	{
	}
}
