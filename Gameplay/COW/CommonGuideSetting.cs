using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200257C")]
public class CommonGuideSetting
{
	[Token(Token = "0x400E7F0")]
	public const int PERMANENT_HINT = -1;

	[Token(Token = "0x400E7F1")]
	[FieldOffset(Offset = "0x8")]
	public TutorialUIType DisplayType;

	[Token(Token = "0x400E7F2")]
	[FieldOffset(Offset = "0xC")]
	public float HideDelay;

	[Token(Token = "0x400E7F3")]
	[FieldOffset(Offset = "0x10")]
	public string HintText;

	[Token(Token = "0x400E7F4")]
	[FieldOffset(Offset = "0x14")]
	public string ParamText;

	[Token(Token = "0x600DB23")]
	[Address(RVA = "0x1737CB8", Offset = "0x1737CB8", VA = "0x1737CB8")]
	public CommonGuideSetting()
	{
	}

	[Token(Token = "0x600DB24")]
	[Address(RVA = "0x1737D58", Offset = "0x1737D58", VA = "0x1737D58")]
	public CommonGuideSetting(TutorialUIType dType, string hint, [Optional] string param, float delay = 0f)
	{
	}
}
