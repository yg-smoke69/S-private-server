using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003481")]
public class UICommonSettingItemView : UIBaseView
{
	[Token(Token = "0x40146F0")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Widget;

	[Token(Token = "0x40146F1")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Mask;

	[Token(Token = "0x40146F2")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LeftLabel;

	[Token(Token = "0x40146F3")]
	[FieldOffset(Offset = "0x20")]
	public UIButton TipBtn;

	[Token(Token = "0x40146F4")]
	[FieldOffset(Offset = "0x24")]
	public UISprite BtnBG;

	[Token(Token = "0x40146F5")]
	[FieldOffset(Offset = "0x28")]
	public UIToggleButtonGroup ToggleGroup;

	[Token(Token = "0x40146F6")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid Grid;

	[Token(Token = "0x40146F7")]
	[FieldOffset(Offset = "0x30")]
	public CommonSettingToggleItem ToggleContainer;

	[Token(Token = "0x40146F8")]
	[FieldOffset(Offset = "0x34")]
	public GameObject RedTips;

	[Token(Token = "0x6016137")]
	[Address(RVA = "0x1EB761C", Offset = "0x1EB761C", VA = "0x1EB761C")]
	public UICommonSettingItemView()
	{
	}

	[Token(Token = "0x6016138")]
	[Address(RVA = "0x1EB7624", Offset = "0x1EB7624", VA = "0x1EB7624", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016139")]
	[Address(RVA = "0x1EB7AB4", Offset = "0x1EB7AB4", VA = "0x1EB7AB4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
