using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200147A")]
public class EHacker
{
	[Token(Token = "0x200147B")]
	public enum HackerPoolCdt
	{
		[Token(Token = "0x4008E22")]
		HackerPoolCdt_NONE = 0,
		[Token(Token = "0x4008E23")]
		HackerPoolCdt_SIGNATURE_LOGIN = 1,
		[Token(Token = "0x4008E24")]
		HackerPoolCdt_ANO = 2,
		[Token(Token = "0x4008E25")]
		HackerPoolCdt_START_TIME = 3,
		[Token(Token = "0x4008E26")]
		HackerPoolCdt_MD5_FILE_EXCEPTION = 4,
		[Token(Token = "0x4008E27")]
		HackerPoolCdt_MD5_SCAN_COUNT = 5,
		[Token(Token = "0x4008E28")]
		HackerPoolCdt_MD5_COUNT = 6,
		[Token(Token = "0x4008E29")]
		HackerPoolCdt_PMS_HOOK = 7,
		[Token(Token = "0x4008E2A")]
		HackerPoolCdt_CLIENT_INFO_EMPTY = 8,
		[Token(Token = "0x4008E2B")]
		HackerPoolCdt_NATIVE_RESULT = 9,
		[Token(Token = "0x4008E2C")]
		HackerPoolCdt_MD5_COUNT_AND_VALUE = 15
	}

	[Token(Token = "0x200147C")]
	public enum HackerCdtManner
	{
		[Token(Token = "0x4008E2E")]
		HackerCdtManner_EQU,
		[Token(Token = "0x4008E2F")]
		HackerCdtManner_CVR,
		[Token(Token = "0x4008E30")]
		HackerCdtManner_GTR,
		[Token(Token = "0x4008E31")]
		HackerCdtManner_LSS,
		[Token(Token = "0x4008E32")]
		HackerCdtManner_JSON_EQU,
		[Token(Token = "0x4008E33")]
		HackerCdtManner_JSON_NOT_EQU,
		[Token(Token = "0x4008E34")]
		HackerCdtManner_EQU_OPPOSITE
	}

	[Token(Token = "0x200147D")]
	public enum HackerCdtID
	{
		[Token(Token = "0x4008E36")]
		HackerCdtID_NONE = 0,
		[Token(Token = "0x4008E37")]
		HackerCdtID_FALSIFY_MEM_VALUE = 100
	}

	[Token(Token = "0x6007B07")]
	[Address(RVA = "0x309F2F8", Offset = "0x309F2F8", VA = "0x309F2F8")]
	public EHacker()
	{
	}
}
