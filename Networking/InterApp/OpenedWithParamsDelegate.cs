using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace InterApp;

[Token(Token = "0x2003EFB")]
public class OpenedWithParamsDelegate
{
	[Token(Token = "0x2003EFC")]
	public class OpenedWithParams
	{
		[Token(Token = "0x401A95C")]
		[FieldOffset(Offset = "0x8")]
		public string DeepLinkUrl;

		[Token(Token = "0x401A95D")]
		[FieldOffset(Offset = "0xC")]
		public string WebViewUrl;

		[Token(Token = "0x401A95E")]
		[FieldOffset(Offset = "0x10")]
		public string WebViewStyle;

		[Token(Token = "0x401A95F")]
		[FieldOffset(Offset = "0x14")]
		public string BrowserUrl;

		[Token(Token = "0x6019A6C")]
		[Address(RVA = "0x3110130", Offset = "0x3110130", VA = "0x3110130")]
		public OpenedWithParams()
		{
		}

		[Token(Token = "0x6019A6D")]
		[Address(RVA = "0x3110138", Offset = "0x3110138", VA = "0x3110138")]
		public bool HasValue()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6019A66")]
	[Address(RVA = "0x310FDCC", Offset = "0x310FDCC", VA = "0x310FDCC")]
	public OpenedWithParamsDelegate()
	{
	}

	[Token(Token = "0x6019A67")]
	[Address(RVA = "0x310FDD4", Offset = "0x310FDD4", VA = "0x310FDD4")]
	protected static bool Has(Dictionary<string, string> parameters, string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6019A68")]
	[Address(RVA = "0x310FEFC", Offset = "0x310FEFC", VA = "0x310FEFC")]
	protected static string _(string v)
	{
		return null;
	}

	[Token(Token = "0x6019A69")]
	[Address(RVA = "0x3110044", Offset = "0x3110044", VA = "0x3110044", Slot = "4")]
	public virtual PlatformUtility.OpenedWith OverrideOpenedWith(PlatformUtility.OpenedWith ow)
	{
		return null;
	}

	[Token(Token = "0x6019A6A")]
	[Address(RVA = "0x31100BC", Offset = "0x31100BC", VA = "0x31100BC", Slot = "5")]
	public virtual bool CanProcess(Dictionary<string, string> parameters)
	{
		return default(bool);
	}

	[Token(Token = "0x6019A6B")]
	[Address(RVA = "0x31100C4", Offset = "0x31100C4", VA = "0x31100C4", Slot = "6")]
	public virtual OpenedWithParams Process(Dictionary<string, string> parameters)
	{
		return null;
	}
}
