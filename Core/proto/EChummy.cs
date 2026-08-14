using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014CF")]
public class EChummy
{
	[Token(Token = "0x20014D0")]
	public enum RequestType
	{
		[Token(Token = "0x4008FE2")]
		RequestType_NONE = 0,
		[Token(Token = "0x4008FE3")]
		RequestType_DISMISS_MENTORING_GRADUATE = 1,
		[Token(Token = "0x4008FE4")]
		RequestType_DISMISS_MENTORING_UNDERGRADUATE = 2,
		[Token(Token = "0x4008FE5")]
		RequestType_DISMISS_MENTORING_AUTO_BREAK = 3,
		[Token(Token = "0x4008FE6")]
		RequestType_Create_MENTORING_APPRENTICE = 1024,
		[Token(Token = "0x4008FE7")]
		RequestType_Create_MENTORING_ENROLL_STUDENT = 1025
	}

	[Token(Token = "0x20014D1")]
	public enum MultiRelationType
	{
		[Token(Token = "0x4008FE9")]
		MultiRelationType_NONE,
		[Token(Token = "0x4008FEA")]
		MultiRelationType_MENTORING
	}

	[Token(Token = "0x20014D2")]
	public enum Role
	{
		[Token(Token = "0x4008FEC")]
		Role_NONE,
		[Token(Token = "0x4008FED")]
		Role_MENTORING_MENTOR,
		[Token(Token = "0x4008FEE")]
		Role_MENTORING_STUDENT
	}

	[Token(Token = "0x20014D3")]
	public enum RelationState
	{
		[Token(Token = "0x4008FF0")]
		RelationState_NONE,
		[Token(Token = "0x4008FF1")]
		RelationState_DISMISS_WAIT,
		[Token(Token = "0x4008FF2")]
		RelationState_DISMISS_DECLINED,
		[Token(Token = "0x4008FF3")]
		RelationState_DISMISS_GRADUATE
	}

	[Token(Token = "0x20014D4")]
	public enum AddIntimacyEventType
	{
		[Token(Token = "0x4008FF5")]
		AddIntimacyEventType_NONE,
		[Token(Token = "0x4008FF6")]
		AddIntimacyEventType_ENDMATCH,
		[Token(Token = "0x4008FF7")]
		AddIntimacyEventType_SENDGIFT,
		[Token(Token = "0x4008FF8")]
		AddIntimacyEventType_BR_SEASONEND,
		[Token(Token = "0x4008FF9")]
		AddIntimacyEventType_CS_SEASONEND
	}

	[Token(Token = "0x6007B29")]
	[Address(RVA = "0x309F280", Offset = "0x309F280", VA = "0x309F280")]
	public EChummy()
	{
	}
}
