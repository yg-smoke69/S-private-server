using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001413")]
public class DisplaySlot
{
	[Token(Token = "0x4008C2D")]
	[FieldOffset(Offset = "0x8")]
	public uint slot_id;

	[Token(Token = "0x4008C2E")]
	[FieldOffset(Offset = "0xC")]
	public uint item_id;

	[Token(Token = "0x6007ADB")]
	[Address(RVA = "0x309F194", Offset = "0x309F194", VA = "0x309F194")]
	public DisplaySlot()
	{
	}
}
