using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BAF")]
public class MuteSwitchDesc
{
	[Token(Token = "0x400AE30")]
	[FieldOffset(Offset = "0x8")]
	public bool enable_api_data;

	[Token(Token = "0x400AE31")]
	[FieldOffset(Offset = "0x9")]
	public bool mute_switch;

	[Token(Token = "0x600820A")]
	[Address(RVA = "0x30A94C8", Offset = "0x30A94C8", VA = "0x30A94C8")]
	public MuteSwitchDesc()
	{
	}
}
