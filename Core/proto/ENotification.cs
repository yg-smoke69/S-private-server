using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001354")]
public class ENotification
{
	[Token(Token = "0x2001355")]
	public enum ChangeMatchInfoEvent
	{
		[Token(Token = "0x4008893")]
		ChangeMatchInfoEvent_NONE,
		[Token(Token = "0x4008894")]
		ChangeMatchInfoEvent_GROUPSTART,
		[Token(Token = "0x4008895")]
		ChangeMatchInfoEvent_CREATEROOM,
		[Token(Token = "0x4008896")]
		ChangeMatchInfoEvent_JOINROOM,
		[Token(Token = "0x4008897")]
		ChangeMatchInfoEvent_SPECTATEROOM,
		[Token(Token = "0x4008898")]
		ChangeMatchInfoEvent_JOINGROUPBYCODE,
		[Token(Token = "0x4008899")]
		ChangeMatchInfoEvent_GROUPJOIN,
		[Token(Token = "0x400889A")]
		ChangeMatchInfoEvent_GROUPLEAVE,
		[Token(Token = "0x400889B")]
		ChangeMatchInfoEvent_GROUPINVITE,
		[Token(Token = "0x400889C")]
		ChangeMatchInfoEvent_GROUPCREATE,
		[Token(Token = "0x400889D")]
		ChangeMatchInfoEvent_CREATEBATCHROOM
	}

	[Token(Token = "0x2001356")]
	public enum ErrCode
	{
		[Token(Token = "0x400889F")]
		ErrCode_SUSS,
		[Token(Token = "0x40088A0")]
		ErrCode_GROUPSTATUS
	}

	[Token(Token = "0x6007A57")]
	[Address(RVA = "0x309F360", Offset = "0x309F360", VA = "0x309F360")]
	public ENotification()
	{
	}
}
