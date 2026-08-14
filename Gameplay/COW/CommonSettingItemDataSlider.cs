using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002599")]
public class CommonSettingItemDataSlider : CommonSettingItemDataBase
{
	[Token(Token = "0x400E8A7")]
	[FieldOffset(Offset = "0x20")]
	public bool IsSlider;

	[Token(Token = "0x400E8A8")]
	[FieldOffset(Offset = "0x24")]
	public Func<float> GetSliderValueFunc;

	[Token(Token = "0x400E8A9")]
	[FieldOffset(Offset = "0x28")]
	public Action<float> SetSliderValue;

	[Token(Token = "0x600DC1E")]
	[Address(RVA = "0x1C7EA70", Offset = "0x1C7EA70", VA = "0x1C7EA70")]
	public CommonSettingItemDataSlider()
	{
	}
}
