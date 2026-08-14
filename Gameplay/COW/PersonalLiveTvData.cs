using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20031E2")]
public class PersonalLiveTvData
{
	[Token(Token = "0x4012FCC")]
	[FieldOffset(Offset = "0x8")]
	public string nickname;

	[Token(Token = "0x4012FCD")]
	[FieldOffset(Offset = "0xC")]
	public uint fancnt;

	[Token(Token = "0x4012FCE")]
	[FieldOffset(Offset = "0x10")]
	public bool isstreamer;

	[Token(Token = "0x4012FCF")]
	[FieldOffset(Offset = "0x14")]
	public ELive.FollowerType followtype;

	[Token(Token = "0x4012FD0")]
	[FieldOffset(Offset = "0x18")]
	public uint headpicid;

	[Token(Token = "0x4012FD1")]
	[FieldOffset(Offset = "0x1C")]
	public EInventory.GenderType sex;

	[Token(Token = "0x60150C5")]
	[Address(RVA = "0x1BF9388", Offset = "0x1BF9388", VA = "0x1BF9388")]
	public PersonalLiveTvData()
	{
	}
}
