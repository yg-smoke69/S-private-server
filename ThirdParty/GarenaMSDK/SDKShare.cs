using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GarenaMSDK;

[Token(Token = "0x2000076")]
public static class SDKShare
{
	[Token(Token = "0x2000077")]
	public enum ShareScene
	{
		[Token(Token = "0x400027F")]
		Chat,
		[Token(Token = "0x4000280")]
		Buzz
	}

	[Token(Token = "0x400027C")]
	[FieldOffset(Offset = "0x0")]
	internal static Action<int, string, long> _SendGameRequestToFacebookUserCallback;

	[Token(Token = "0x400027D")]
	[FieldOffset(Offset = "0x8")]
	internal static long _CallBackFBUid;

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x3465FF0", Offset = "0x3465FF0", VA = "0x3465FF0")]
	public static void SendGameToSession(int scene, string title, string description, string mediaTag, string caption, string url, string imagePath, int compressRate)
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x3466470", Offset = "0x3466470", VA = "0x3466470")]
	public static void SendMediaToSession(int scene, string mediaTag, string messageExt, string imagePath)
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x3466760", Offset = "0x3466760", VA = "0x3466760")]
	public static void SendLinkToSession(int scene, string mediaTag, string url, string title, string caption, string description, string mediaUrl)
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x3466B64", Offset = "0x3466B64", VA = "0x3466B64")]
	public static void ShareToFacebook(int scene, string name, string caption, string description, string link, string imagePath, int compressRate, string mediaUrl)
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x3466F64", Offset = "0x3466F64", VA = "0x3466F64")]
	public static void SendLinkToFacebook(string name, string caption, string description, string link, string mediaUrl)
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x3467290", Offset = "0x3467290", VA = "0x3467290")]
	public static void SendRequestInvitationToFacebook(string title, string message)
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x3467498", Offset = "0x3467498", VA = "0x3467498")]
	public static void SendLinkToVKontakte(string message, string url)
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x34677C4", Offset = "0x34677C4", VA = "0x34677C4")]
	public static void ShareToVKontakte(string message, string url, string imagePath, int compressRate)
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x3467864", Offset = "0x3467864", VA = "0x3467864")]
	public static void SendGameRequestToFacebookUser(long fbUid, string title, string message, string data, [Optional] Action<int, string, long> callback)
	{
	}
}
