using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20003A7")]
public class FacebookUtility
{
	[Token(Token = "0x40037A2")]
	[FieldOffset(Offset = "0x0")]
	private static FacebookUtility _instance;

	[Token(Token = "0x40037A3")]
	[FieldOffset(Offset = "0x8")]
	public Action<string> OnLoginFailed;

	[Token(Token = "0x40037A4")]
	[FieldOffset(Offset = "0xC")]
	public Action OnLoginSucess;

	[Token(Token = "0x40037A5")]
	[FieldOffset(Offset = "0x10")]
	public Action OnLoginCancel;

	[Token(Token = "0x40037A6")]
	[FieldOffset(Offset = "0x4")]
	private static string FacebookURL_Web;

	[Token(Token = "0x40037A7")]
	[FieldOffset(Offset = "0x8")]
	private static string FacebookURL_APP;

	[Token(Token = "0x6000F1F")]
	[Address(RVA = "0xDE3398", Offset = "0xDE3398", VA = "0xDE3398")]
	public FacebookUtility()
	{
	}

	[Token(Token = "0x6000F20")]
	[Address(RVA = "0xDE33A0", Offset = "0xDE33A0", VA = "0xDE33A0")]
	public static FacebookUtility Instance()
	{
		return null;
	}

	[Token(Token = "0x6000F21")]
	[Address(RVA = "0xDE3510", Offset = "0xDE3510", VA = "0xDE3510")]
	public void OpenFBMainPage(string fbEventID)
	{
	}
}
