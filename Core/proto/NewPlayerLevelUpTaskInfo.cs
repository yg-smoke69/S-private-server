using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015F0")]
public class NewPlayerLevelUpTaskInfo
{
	[Token(Token = "0x400949B")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400949C")]
	[FieldOffset(Offset = "0xC")]
	public uint data;

	[Token(Token = "0x400949D")]
	[FieldOffset(Offset = "0x10")]
	public EActivity.State state;

	[Token(Token = "0x6007C3A")]
	[Address(RVA = "0x30A9DE4", Offset = "0x30A9DE4", VA = "0x30A9DE4")]
	public NewPlayerLevelUpTaskInfo()
	{
	}
}
