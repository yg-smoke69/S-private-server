using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A1D")]
public class CloseBetaConfigDesc
{
	[Token(Token = "0x400A3AD")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A3AE")]
	[FieldOffset(Offset = "0xC")]
	public EAccount.CBSwitchStatus switch_status;

	[Token(Token = "0x400A3AF")]
	[FieldOffset(Offset = "0x10")]
	public List<string> versions;

	[Token(Token = "0x400A3B0")]
	[FieldOffset(Offset = "0x14")]
	public uint platform;

	[Token(Token = "0x400A3B1")]
	[FieldOffset(Offset = "0x18")]
	public EAccount.TrialSwitchStatus trial_status;

	[Token(Token = "0x6008075")]
	[Address(RVA = "0x309CA40", Offset = "0x309CA40", VA = "0x309CA40")]
	public CloseBetaConfigDesc()
	{
	}
}
