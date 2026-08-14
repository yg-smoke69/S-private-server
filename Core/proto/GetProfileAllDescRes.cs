using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001669")]
public class GetProfileAllDescRes
{
	[Token(Token = "0x400961E")]
	[FieldOffset(Offset = "0x8")]
	public CSGetUnlockProfileInfoRes profile;

	[Token(Token = "0x400961F")]
	[FieldOffset(Offset = "0xC")]
	public CSGetHideAvatarRes hide;

	[Token(Token = "0x4009620")]
	[FieldOffset(Offset = "0x10")]
	public CSGetAvatarAwakenRes avatar_awaken;

	[Token(Token = "0x4009621")]
	[FieldOffset(Offset = "0x14")]
	public CSGetGoPosRes go_pos;

	[Token(Token = "0x6007CB3")]
	[Address(RVA = "0x30A2240", Offset = "0x30A2240", VA = "0x30A2240")]
	public GetProfileAllDescRes()
	{
	}
}
