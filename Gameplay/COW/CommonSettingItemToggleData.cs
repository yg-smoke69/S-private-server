using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200259C")]
public class CommonSettingItemToggleData
{
	[Token(Token = "0x400E8BA")]
	[FieldOffset(Offset = "0x8")]
	public string BtnKey;

	[Token(Token = "0x400E8BB")]
	[FieldOffset(Offset = "0xC")]
	public Action BtnClickCallBack;

	[Token(Token = "0x400E8BC")]
	[FieldOffset(Offset = "0x10")]
	public Func<bool> IsEnable;

	[Token(Token = "0x600DC20")]
	[Address(RVA = "0x1C7EBB4", Offset = "0x1C7EBB4", VA = "0x1C7EBB4")]
	public CommonSettingItemToggleData()
	{
	}
}
