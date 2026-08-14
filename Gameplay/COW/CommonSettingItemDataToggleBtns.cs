using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002598")]
public class CommonSettingItemDataToggleBtns : CommonSettingItemDataBase
{
	[Token(Token = "0x400E8A0")]
	[FieldOffset(Offset = "0x20")]
	public bool ShowBtnBG;

	[Token(Token = "0x400E8A1")]
	[FieldOffset(Offset = "0x24")]
	public List<CommonSettingItemToggleData> ToggleData;

	[Token(Token = "0x400E8A2")]
	[FieldOffset(Offset = "0x28")]
	public Func<int> GetBtnSelectFromRightToLeft;

	[Token(Token = "0x400E8A3")]
	[FieldOffset(Offset = "0x2C")]
	public string CommonPrefsKey;

	[Token(Token = "0x400E8A4")]
	[FieldOffset(Offset = "0x30")]
	public List<int> CommonPrefsValue;

	[Token(Token = "0x400E8A5")]
	[FieldOffset(Offset = "0x34")]
	public List<string> CommonPrefsToggleKey;

	[Token(Token = "0x400E8A6")]
	[FieldOffset(Offset = "0x38")]
	public int DefalutValue;

	[Token(Token = "0x600DC1D")]
	[Address(RVA = "0x1C7EA74", Offset = "0x1C7EA74", VA = "0x1C7EA74")]
	public CommonSettingItemDataToggleBtns()
	{
	}
}
