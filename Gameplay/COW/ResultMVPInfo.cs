using COW.GamePlay;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003260")]
internal class ResultMVPInfo
{
	[Token(Token = "0x40132B2")]
	[FieldOffset(Offset = "0x8")]
	public string Nickname;

	[Token(Token = "0x40132B3")]
	[FieldOffset(Offset = "0x10")]
	public IHAAMHPPLMG id;

	[Token(Token = "0x40132B4")]
	[FieldOffset(Offset = "0x28")]
	public uint Kill;

	[Token(Token = "0x40132B5")]
	[FieldOffset(Offset = "0x2C")]
	public uint Damage;

	[Token(Token = "0x40132B6")]
	[FieldOffset(Offset = "0x30")]
	public uint Survival;

	[Token(Token = "0x60153D4")]
	[Address(RVA = "0x2408C98", Offset = "0x2408C98", VA = "0x2408C98")]
	public ResultMVPInfo()
	{
	}
}
