using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

[Token(Token = "0x2003B71")]
public static class GGP
{
	[Token(Token = "0x401953D")]
	[FieldOffset(Offset = "0x0")]
	private static bool isInitialized;

	[Token(Token = "0x401953E")]
	[FieldOffset(Offset = "0x4")]
	private static int initRet;

	[Token(Token = "0x401953F")]
	[FieldOffset(Offset = "0x8")]
	private static bool isSetGGPFlag;

	[Token(Token = "0x4019540")]
	private const string version = "5.1";

	[Token(Token = "0x4019541")]
	[FieldOffset(Offset = "0xC")]
	private static string strDesc;

	[Token(Token = "0x4019542")]
	[FieldOffset(Offset = "0x10")]
	private static long MAX_UT_FLAG;

	[Token(Token = "0x4019543")]
	[FieldOffset(Offset = "0x18")]
	private static long _ut_flag;

	[Token(Token = "0x4019544")]
	[FieldOffset(Offset = "0x20")]
	private static string _ut_data;

	[Token(Token = "0x4019545")]
	[FieldOffset(Offset = "0x24")]
	private static string _sn_data;

	[Token(Token = "0x4019546")]
	[FieldOffset(Offset = "0x28")]
	private static long MAX_FLAG;

	[Token(Token = "0x4019547")]
	[FieldOffset(Offset = "0x30")]
	private static long[] flags;

	[Token(Token = "0x4019548")]
	[FieldOffset(Offset = "0x34")]
	private static float mLastGetTime;

	[Token(Token = "0x4019549")]
	[FieldOffset(Offset = "0x38")]
	private static string mCacheInfo;

	[Token(Token = "0x6017A91")]
	[Address(RVA = "0x2BDC9F8", Offset = "0x2BDC9F8", VA = "0x2BDC9F8")]
	public static void SetSwitchDesc(string desc)
	{
	}

	[Token(Token = "0x6017A92")]
	[Address(RVA = "0x2BDCF08", Offset = "0x2BDCF08", VA = "0x2BDCF08")]
	public static void SetGGPInfo(ReportGGPInfo info)
	{
	}

	[Token(Token = "0x6017A93")]
	[Address(RVA = "0x2BDD344", Offset = "0x2BDD344", VA = "0x2BDD344")]
	public static int Init(bool is_low_mem)
	{
		return default(int);
	}

	[Token(Token = "0x6017A94")]
	[Address(RVA = "0x2BDE1E0", Offset = "0x2BDE1E0", VA = "0x2BDE1E0")]
	public static int setUserInfo(string roleName, string roleAccount, string roleId)
	{
		return default(int);
	}

	[Token(Token = "0x6017A95")]
	[Address(RVA = "0x2BDE468", Offset = "0x2BDE468", VA = "0x2BDE468")]
	public static int setUserInfoEx(string roleName, string roleAccount, string roleId, string serverName, string channelName, string gameJson)
	{
		return default(int);
	}

	[Token(Token = "0x6017A96")]
	[Address(RVA = "0x2BDDFE4", Offset = "0x2BDDFE4", VA = "0x2BDDFE4")]
	public static int setUTData(string utData)
	{
		return default(int);
	}

	[Token(Token = "0x6017A97")]
	[Address(RVA = "0x2BDE08C", Offset = "0x2BDE08C", VA = "0x2BDE08C")]
	public static int setSNData(string snData)
	{
		return default(int);
	}

	[Token(Token = "0x6017A98")]
	[Address(RVA = "0x2BDE688", Offset = "0x2BDE688", VA = "0x2BDE688")]
	public static string getSign(string inputData)
	{
		return null;
	}

	[Token(Token = "0x6017A99")]
	[Address(RVA = "0x2BDE744", Offset = "0x2BDE744", VA = "0x2BDE744")]
	public static string setGGPId(int fairId)
	{
		return null;
	}

	[Token(Token = "0x6017A9A")]
	[Address(RVA = "0x2BDDF38", Offset = "0x2BDDF38", VA = "0x2BDDF38")]
	public static int setGGPFlag(long ggpFlag)
	{
		return default(int);
	}

	[Token(Token = "0x6017A9B")]
	[Address(RVA = "0x2BDE134", Offset = "0x2BDE134", VA = "0x2BDE134")]
	public static int setUTFlag(long utFlag)
	{
		return default(int);
	}

	[Token(Token = "0x6017A9C")]
	[Address(RVA = "0x2BDEDD0", Offset = "0x2BDEDD0", VA = "0x2BDEDD0")]
	public static int setInMatch()
	{
		return default(int);
	}

	[Token(Token = "0x6017A9D")]
	[Address(RVA = "0x2BDEE74", Offset = "0x2BDEE74", VA = "0x2BDEE74")]
	public static string GetData(bool need_ios)
	{
		return null;
	}

	[Token(Token = "0x6017A9E")]
	[Address(RVA = "0x2BDF2EC", Offset = "0x2BDF2EC", VA = "0x2BDF2EC")]
	public static int GetFlag()
	{
		return default(int);
	}

	[Token(Token = "0x6017A9F")]
	[Address(RVA = "0x2BDF378", Offset = "0x2BDF378", VA = "0x2BDF378")]
	public static string GetSwitchStr()
	{
		return null;
	}

	[PreserveSig]
	[Token(Token = "0x6017AA0")]
	[Address(RVA = "0x2BDDE00", Offset = "0x2BDDE00", VA = "0x2BDDE00")]
	private static extern int cxa_current_primary_free_exception(int nFunId, int nArg1, int nArg2, int nArg3, long llArg1, string pInput1, IntPtr pInt);

	[PreserveSig]
	[Token(Token = "0x6017AA1")]
	[Address(RVA = "0x2BDEC88", Offset = "0x2BDEC88", VA = "0x2BDEC88")]
	private static extern IntPtr cxa_current_primary_mal_exception(int nFunId, int nArg1, int nArg2, int nArg3, long llArg1, string pInput1, string pInput2);

	[PreserveSig]
	[Token(Token = "0x6017AA2")]
	[Address(RVA = "0x2BDE2D8", Offset = "0x2BDE2D8", VA = "0x2BDE2D8")]
	private static extern int cxa_current_primary_set_exception(int nFunId, int nArg1, string pInput1, string pInput2, string pInput3, string pInput4, string pInput5, string pInput6);
}
