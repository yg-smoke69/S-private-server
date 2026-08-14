using System.Collections.Generic;
using Il2CppDummyDll;

namespace InterApp;

[Token(Token = "0x2003EFA")]
public class OpenedByUrlProcessorManager
{
	[Token(Token = "0x401A959")]
	[FieldOffset(Offset = "0x0")]
	private static OpenedByUrlProcessorManager _I;

	[Token(Token = "0x401A95A")]
	[FieldOffset(Offset = "0x4")]
	private static readonly char[] URL_STRIP_SEPARATOR;

	[Token(Token = "0x401A95B")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<string, OpenedByUrlProcessor> _UriToProcessor;

	[Token(Token = "0x17001C11")]
	public static OpenedByUrlProcessorManager I
	{
		[Token(Token = "0x6019A61")]
		[Address(RVA = "0x310F9FC", Offset = "0x310F9FC", VA = "0x310F9FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C12")]
	public OpenedByUrlProcessor Item
	{
		[Token(Token = "0x6019A63")]
		[Address(RVA = "0x310FB24", Offset = "0x310FB24", VA = "0x310FB24")]
		get
		{
			return null;
		}
		[Token(Token = "0x6019A64")]
		[Address(RVA = "0x310FC1C", Offset = "0x310FC1C", VA = "0x310FC1C")]
		set
		{
		}
	}

	[Token(Token = "0x6019A60")]
	[Address(RVA = "0x310F970", Offset = "0x310F970", VA = "0x310F970")]
	private OpenedByUrlProcessorManager()
	{
	}

	[Token(Token = "0x6019A62")]
	[Address(RVA = "0x310E744", Offset = "0x310E744", VA = "0x310E744")]
	public static string UrlStrip(string uri)
	{
		return null;
	}
}
