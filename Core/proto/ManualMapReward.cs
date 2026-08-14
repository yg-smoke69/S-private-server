using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200177E")]
public class ManualMapReward
{
	[Token(Token = "0x4009A5E")]
	[FieldOffset(Offset = "0x8")]
	public uint map_id;

	[Token(Token = "0x4009A5F")]
	[FieldOffset(Offset = "0xC")]
	public EManual.State state;

	[Token(Token = "0x6007DD8")]
	[Address(RVA = "0x30A7858", Offset = "0x30A7858", VA = "0x30A7858")]
	public ManualMapReward()
	{
	}
}
