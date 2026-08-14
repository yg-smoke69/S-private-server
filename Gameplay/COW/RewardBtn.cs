using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200249C")]
public class RewardBtn
{
	[Token(Token = "0x400E2EA")]
	[FieldOffset(Offset = "0x8")]
	public string BtnTitle;

	[Token(Token = "0x400E2EB")]
	[FieldOffset(Offset = "0xC")]
	public Action OnBtnClick;

	[Token(Token = "0x600D156")]
	[Address(RVA = "0x2409A9C", Offset = "0x2409A9C", VA = "0x2409A9C")]
	public RewardBtn()
	{
	}
}
