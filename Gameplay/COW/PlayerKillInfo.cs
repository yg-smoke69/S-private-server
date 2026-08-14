using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200325A")]
internal class PlayerKillInfo
{
	[Token(Token = "0x401328A")]
	[FieldOffset(Offset = "0x8")]
	public string nickname;

	[Token(Token = "0x401328B")]
	[FieldOffset(Offset = "0xC")]
	public int weaponID;

	[Token(Token = "0x401328C")]
	[FieldOffset(Offset = "0x10")]
	public uint headicon;

	[Token(Token = "0x60153CE")]
	[Address(RVA = "0x1C08EE4", Offset = "0x1C08EE4", VA = "0x1C08EE4")]
	public PlayerKillInfo()
	{
	}
}
