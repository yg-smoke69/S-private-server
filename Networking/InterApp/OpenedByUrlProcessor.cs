using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace InterApp;

[Token(Token = "0x2003EF7")]
public class OpenedByUrlProcessor
{
	[Token(Token = "0x2003EF8")]
	public delegate bool WillProcessDelegate(string url);

	[Token(Token = "0x2003EF9")]
	public delegate void ProcessDelegate(string url);

	[Token(Token = "0x401A952")]
	[FieldOffset(Offset = "0x8")]
	public WillProcessDelegate WillProcessFallback;

	[Token(Token = "0x401A953")]
	[FieldOffset(Offset = "0xC")]
	public ProcessDelegate ProcessFallback;

	[Token(Token = "0x401A954")]
	[FieldOffset(Offset = "0x10")]
	private string _Url;

	[Token(Token = "0x401A955")]
	[FieldOffset(Offset = "0x14")]
	private string _ActionKey;

	[Token(Token = "0x401A956")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, InterAppActionType> _ActionToType;

	[Token(Token = "0x401A957")]
	[FieldOffset(Offset = "0x0")]
	private static readonly char[] PARAMETER_PAIR_SEPARATOR;

	[Token(Token = "0x401A958")]
	[FieldOffset(Offset = "0x4")]
	private static readonly char[] PARAMETER_KEY_VALUE_SEPARATOR;

	[Token(Token = "0x17001C0E")]
	public string Url
	{
		[Token(Token = "0x6019A4F")]
		[Address(RVA = "0x310DEFC", Offset = "0x310DEFC", VA = "0x310DEFC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C0F")]
	public string ActionKey
	{
		[Token(Token = "0x6019A50")]
		[Address(RVA = "0x310DF04", Offset = "0x310DF04", VA = "0x310DF04")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C10")]
	public InterAppActionType Item
	{
		[Token(Token = "0x6019A51")]
		[Address(RVA = "0x310DF0C", Offset = "0x310DF0C", VA = "0x310DF0C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6019A52")]
		[Address(RVA = "0x310DFCC", Offset = "0x310DFCC", VA = "0x310DFCC")]
		set
		{
		}
	}

	[Token(Token = "0x6019A4E")]
	[Address(RVA = "0x310DE0C", Offset = "0x310DE0C", VA = "0x310DE0C")]
	public OpenedByUrlProcessor(string url, string actionKey)
	{
	}

	[Token(Token = "0x6019A53")]
	[Address(RVA = "0x310E054", Offset = "0x310E054", VA = "0x310E054")]
	public string Prepare(string url, string action, [Optional] Dictionary<string, string> parameters)
	{
		return null;
	}

	[Token(Token = "0x6019A54")]
	[Address(RVA = "0x310E8B4", Offset = "0x310E8B4", VA = "0x310E8B4")]
	private bool ExtractParameters(string url, out InterAppActionType actionType, out InterAppAction action)
	{
		return default(bool);
	}

	[Token(Token = "0x6019A55")]
	[Address(RVA = "0x310EF1C", Offset = "0x310EF1C", VA = "0x310EF1C")]
	public bool WillProcess(string url)
	{
		return default(bool);
	}

	[Token(Token = "0x6019A56")]
	[Address(RVA = "0x310F344", Offset = "0x310F344", VA = "0x310F344")]
	public void Process(string url)
	{
	}
}
