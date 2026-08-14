using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A23")]
public class UIUGCCreateNewWorkshopView : UIBaseView
{
	[Token(Token = "0x40188C8")]
	[FieldOffset(Offset = "0x14")]
	public UIEasyList ModeGridEasyList;

	[Token(Token = "0x40188C9")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ModeName;

	[Token(Token = "0x40188CA")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel ModeType;

	[Token(Token = "0x40188CB")]
	[FieldOffset(Offset = "0x20")]
	public UIEasyList MapGridEasyList;

	[Token(Token = "0x40188CC")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnApply;

	[Token(Token = "0x40188CD")]
	[FieldOffset(Offset = "0x28")]
	public UINetworkTexture CDNBg;

	[Token(Token = "0x40188CE")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggleButton BtnClassic;

	[Token(Token = "0x40188CF")]
	[FieldOffset(Offset = "0x30")]
	public UIToggleButton BtnTemplate;

	[Token(Token = "0x601720F")]
	[Address(RVA = "0x2B8E59C", Offset = "0x2B8E59C", VA = "0x2B8E59C")]
	public UIUGCCreateNewWorkshopView()
	{
	}

	[Token(Token = "0x6017210")]
	[Address(RVA = "0x2B8E5A4", Offset = "0x2B8E5A4", VA = "0x2B8E5A4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017211")]
	[Address(RVA = "0x2B8E9EC", Offset = "0x2B8E9EC", VA = "0x2B8E9EC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
