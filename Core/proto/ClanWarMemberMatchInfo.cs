using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013C4")]
public class ClanWarMemberMatchInfo
{
	[Token(Token = "0x4008AFA")]
	[FieldOffset(Offset = "0x8")]
	public ulong member_id;

	[Token(Token = "0x4008AFB")]
	[FieldOffset(Offset = "0x10")]
	public string signature_md5;

	[Token(Token = "0x4008AFC")]
	[FieldOffset(Offset = "0x14")]
	public uint using_version;

	[Token(Token = "0x4008AFD")]
	[FieldOffset(Offset = "0x18")]
	public uint system_platform;

	[Token(Token = "0x4008AFE")]
	[FieldOffset(Offset = "0x1C")]
	public MatchClientInfo client_info;

	[Token(Token = "0x6007AAF")]
	[Address(RVA = "0x309C308", Offset = "0x309C308", VA = "0x309C308")]
	public ClanWarMemberMatchInfo()
	{
	}
}
