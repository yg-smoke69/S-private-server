using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002595")]
public class CommonSettingContentData
{
	[Token(Token = "0x400E896")]
	[FieldOffset(Offset = "0x8")]
	public bool ShowTitle;

	[Token(Token = "0x400E897")]
	[FieldOffset(Offset = "0xC")]
	public string TitleKey;

	[Token(Token = "0x400E898")]
	[FieldOffset(Offset = "0x10")]
	public string TitleDesc;

	[Token(Token = "0x400E899")]
	[FieldOffset(Offset = "0x14")]
	public bool ShowBG;

	[Token(Token = "0x400E89A")]
	[FieldOffset(Offset = "0x18")]
	public Dictionary<int, CommonSettingItemDataBase> ItemData;

	[Token(Token = "0x400E89B")]
	[FieldOffset(Offset = "0x1C")]
	public bool Show;

	[Token(Token = "0x600DC0F")]
	[Address(RVA = "0x1C7E8BC", Offset = "0x1C7E8BC", VA = "0x1C7E8BC")]
	public CommonSettingContentData()
	{
	}
}
