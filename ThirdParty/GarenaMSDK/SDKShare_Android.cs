using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GarenaMSDK;

[Token(Token = "0x2000078")]
public static class SDKShare_Android
{
	[Serializable]
	[Token(Token = "0x2000079")]
	public class PluginResult
	{
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x8")]
		public int status;

		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0xC")]
		public string message;

		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x10")]
		public string source;

		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x14")]
		public int flag;

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x3467CDC", Offset = "0x3467CDC", VA = "0x3467CDC")]
		public PluginResult()
		{
		}
	}

	[Token(Token = "0x4000281")]
	[FieldOffset(Offset = "0x0")]
	private static AndroidJavaClass _Share;

	[Token(Token = "0x1700006A")]
	private static AndroidJavaClass Share
	{
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x3467B88", Offset = "0x3467B88", VA = "0x3467B88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x34660B0", Offset = "0x34660B0", VA = "0x34660B0")]
	public static void SendGameToSession(int scene, string title, string description, string mediaTag, string caption, string url, string imagePath, int compressRate)
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x3466510", Offset = "0x3466510", VA = "0x3466510")]
	public static void SendMediaToSession(int scene, string mediaTag, string messageExt, string imagePath)
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x3466818", Offset = "0x3466818", VA = "0x3466818")]
	public static void SendLinkToSession(int scene, string mediaTag, string url, string title, string caption, string description, string mediaUrl)
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x3466C18", Offset = "0x3466C18", VA = "0x3466C18")]
	public static void ShareToFacebook(int scene, string name, string caption, string description, string link, string imagePath, int compressRate, string mediaUrl)
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x346700C", Offset = "0x346700C", VA = "0x346700C")]
	public static void SendLinkToFacebook(string name, string caption, string description, string link, string mediaUrl)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x3467318", Offset = "0x3467318", VA = "0x3467318")]
	public static void SendRequestInvitationToFacebook(string title, string message)
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x3467934", Offset = "0x3467934", VA = "0x3467934")]
	public static void SendGameRequestToFacebookUser(long fbUid, string title, string message, string data)
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x3467574", Offset = "0x3467574", VA = "0x3467574")]
	public static void ShareToVKontakte(string message, string url, string imagePath, int compressRate)
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x3450044", Offset = "0x3450044", VA = "0x3450044")]
	internal static void SendGameRequestToFacebookUserCallback(string pluginResultString)
	{
	}
}
