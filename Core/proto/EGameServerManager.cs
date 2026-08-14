using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001310")]
public class EGameServerManager
{
	[Token(Token = "0x2001311")]
	public enum Proto
	{
		[Token(Token = "0x40086F4")]
		Proto_NONE,
		[Token(Token = "0x40086F5")]
		Proto_REPORT,
		[Token(Token = "0x40086F6")]
		Proto_PLAYERLOGIN,
		[Token(Token = "0x40086F7")]
		Proto_PLAYERLOGOUT,
		[Token(Token = "0x40086F8")]
		Proto_ENDMATCH,
		[Token(Token = "0x40086F9")]
		Proto_CUSTOMROOM_MATCHSTATS,
		[Token(Token = "0x40086FA")]
		Proto_UPDATE_INGAMEITEMS,
		[Token(Token = "0x40086FB")]
		Proto_GS_READY,
		[Token(Token = "0x40086FC")]
		Proto_UGC_DEBUG_GS_READY
	}

	[Token(Token = "0x2001312")]
	public enum ErrCode
	{
		[Token(Token = "0x40086FE")]
		ErrCode_SUSS = 0,
		[Token(Token = "0x40086FF")]
		ErrCode_ROOMFULL = 8
	}

	[Token(Token = "0x2001313")]
	public enum HandleGSLoad
	{
		[Token(Token = "0x4008701")]
		HandleGSLoad_NONE,
		[Token(Token = "0x4008702")]
		HandleGSLoad_UPDATE,
		[Token(Token = "0x4008703")]
		HandleGSLoad_DELETE
	}

	[Token(Token = "0x6007A4B")]
	[Address(RVA = "0x309F2E8", Offset = "0x309F2E8", VA = "0x309F2E8")]
	public EGameServerManager()
	{
	}
}
