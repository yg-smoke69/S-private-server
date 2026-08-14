using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2004137")]
public class CountDownConfig
{
	[Token(Token = "0x401B5FA")]
	[FieldOffset(Offset = "0x8")]
	public ulong m_EndTime;

	[Token(Token = "0x401B5FB")]
	[FieldOffset(Offset = "0x10")]
	public string m_Prefix;

	[Token(Token = "0x401B5FC")]
	[FieldOffset(Offset = "0x14")]
	public string m_Suffix;

	[Token(Token = "0x401B5FD")]
	[FieldOffset(Offset = "0x18")]
	public bool m_Formated;

	[Token(Token = "0x401B5FE")]
	[FieldOffset(Offset = "0x1C")]
	public OnStarted m_OnStarted;

	[Token(Token = "0x401B5FF")]
	[FieldOffset(Offset = "0x20")]
	public OnFinished m_OnFinished;

	[Token(Token = "0x401B600")]
	[FieldOffset(Offset = "0x24")]
	public bool m_ShortDisplay;

	[Token(Token = "0x401B601")]
	[FieldOffset(Offset = "0x25")]
	public bool m_IsStarted;

	[Token(Token = "0x401B602")]
	[FieldOffset(Offset = "0x26")]
	public bool m_FuzzyDisplay;

	[Token(Token = "0x601AA60")]
	[Address(RVA = "0x1C80604", Offset = "0x1C80604", VA = "0x1C80604")]
	public CountDownConfig()
	{
	}
}
