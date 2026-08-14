using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200259B")]
public class CommonSettingItemDataBase
{
	[Token(Token = "0x400E8B1")]
	[FieldOffset(Offset = "0x8")]
	public string LeftLabelKey;

	[Token(Token = "0x400E8B2")]
	[FieldOffset(Offset = "0xC")]
	public Action TipBtnClickCallBack;

	[Token(Token = "0x400E8B3")]
	[FieldOffset(Offset = "0x10")]
	public bool ShowTipBtn;

	[Token(Token = "0x400E8B4")]
	[FieldOffset(Offset = "0x11")]
	public bool ShowItem;

	[Token(Token = "0x400E8B5")]
	[FieldOffset(Offset = "0x12")]
	public bool ShowRedTips;

	[Token(Token = "0x400E8B6")]
	[FieldOffset(Offset = "0x14")]
	public string tipsKey;

	[Token(Token = "0x400E8B7")]
	[FieldOffset(Offset = "0x18")]
	public bool EnableInSetting;

	[Token(Token = "0x400E8B8")]
	[FieldOffset(Offset = "0x19")]
	public bool interactable;

	[Token(Token = "0x400E8B9")]
	[FieldOffset(Offset = "0x1C")]
	public int Type;

	[Token(Token = "0x600DC1F")]
	[Address(RVA = "0x1C7E9AC", Offset = "0x1C7E9AC", VA = "0x1C7E9AC")]
	public CommonSettingItemDataBase()
	{
	}
}
