using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001C8A")]
public class EClan
{
	[Token(Token = "0x2001C8B")]
	public enum Proto
	{
		[Token(Token = "0x400B510")]
		Proto_NONE,
		[Token(Token = "0x400B511")]
		Proto_REQUEST_JOIN_NTF,
		[Token(Token = "0x400B512")]
		Proto_CONFIRM_ADD_NTF,
		[Token(Token = "0x400B513")]
		Proto_REMOVE_MEMBER_NTF,
		[Token(Token = "0x400B514")]
		Proto_INVITE_NTF,
		[Token(Token = "0x400B515")]
		Proto_APPROVE_INVITATION_NTF,
		[Token(Token = "0x400B516")]
		Proto_DISMISS_NTF,
		[Token(Token = "0x400B517")]
		Proto_AUTO_JOIN_NTF,
		[Token(Token = "0x400B518")]
		Proto_NEW_LUCKY_BAG_NTF,
		[Token(Token = "0x400B519")]
		Proto_APPLY_FOR_DEPUTY_NTF,
		[Token(Token = "0x400B51A")]
		Proto_DEPUTY_CAPTAIN_NTF,
		[Token(Token = "0x400B51B")]
		Proto_JOIN_CLAN_WAR_NTF,
		[Token(Token = "0x400B51C")]
		Proto_QUIT_CLAN_WAR_NTF,
		[Token(Token = "0x400B51D")]
		Proto_REMOVE_CLAN_WAR_MEMBER_NTF,
		[Token(Token = "0x400B51E")]
		Proto_APPOINT_CLAN_WAR_NEW_CAPTAIN_NTF,
		[Token(Token = "0x400B51F")]
		Proto_PREPARE_CLAN_WAR_NTF,
		[Token(Token = "0x400B520")]
		Proto_INVITE_CLAN_WAR_NTF,
		[Token(Token = "0x400B521")]
		Proto_CLAN_WAR_MEMBER_PREPARE_NTF
	}

	[Token(Token = "0x2001C8C")]
	public enum ErrCode
	{
		[Token(Token = "0x400B523")]
		ErrCode_SUSS
	}

	[Token(Token = "0x60083B8")]
	[Address(RVA = "0x33E8FFC", Offset = "0x33E8FFC", VA = "0x33E8FFC")]
	public EClan()
	{
	}
}
