using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200398D")]
public class UIRushingPetsCreateRoomView : UIBaseView
{
	[Token(Token = "0x40181A0")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel TopPanel;

	[Token(Token = "0x40181A1")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x40181A2")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject RoomGameSettingBtnGo;

	[Token(Token = "0x40181A3")]
	[FieldOffset(Offset = "0x20")]
	public UIButton close;

	[Token(Token = "0x40181A4")]
	[FieldOffset(Offset = "0x24")]
	public GameObject InfoPanel;

	[Token(Token = "0x40181A5")]
	[FieldOffset(Offset = "0x28")]
	public UIWidget RoomSettingPanel;

	[Token(Token = "0x40181A6")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Map;

	[Token(Token = "0x40181A7")]
	[FieldOffset(Offset = "0x30")]
	public UILabel MapName;

	[Token(Token = "0x40181A8")]
	[FieldOffset(Offset = "0x34")]
	public UIInput NameInput;

	[Token(Token = "0x40181A9")]
	[FieldOffset(Offset = "0x38")]
	public UIInput CodeInput;

	[Token(Token = "0x40181AA")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject PlayerCountSettingRoot;

	[Token(Token = "0x40181AB")]
	[FieldOffset(Offset = "0x40")]
	public UILabel SettingPagePlayerCountLabel;

	[Token(Token = "0x40181AC")]
	[FieldOffset(Offset = "0x44")]
	public UIWidget PlayerCountPopMenu;

	[Token(Token = "0x40181AD")]
	[FieldOffset(Offset = "0x48")]
	public UIToggleButton SoloToggle;

	[Token(Token = "0x40181AE")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite SoloLabelCheckmark;

	[Token(Token = "0x40181AF")]
	[FieldOffset(Offset = "0x50")]
	public UILabel SoloLabel;

	[Token(Token = "0x40181B0")]
	[FieldOffset(Offset = "0x54")]
	public UIToggleButton DuoToggle;

	[Token(Token = "0x40181B1")]
	[FieldOffset(Offset = "0x58")]
	public UISprite DuoCheckmark;

	[Token(Token = "0x40181B2")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel DuoLabel;

	[Token(Token = "0x40181B3")]
	[FieldOffset(Offset = "0x60")]
	public UIToggleButton QuadToggle;

	[Token(Token = "0x40181B4")]
	[FieldOffset(Offset = "0x64")]
	public UISprite QuadCheckmark;

	[Token(Token = "0x40181B5")]
	[FieldOffset(Offset = "0x68")]
	public UILabel QuadLabel;

	[Token(Token = "0x40181B6")]
	[FieldOffset(Offset = "0x6C")]
	public UIButton CreateRoomBtn2;

	[Token(Token = "0x40181B7")]
	[FieldOffset(Offset = "0x70")]
	public UIPanel RoomSettingMaskPanel;

	[Token(Token = "0x40181B8")]
	[FieldOffset(Offset = "0x74")]
	public UIButton RoomSettingMask;

	[Token(Token = "0x40181B9")]
	[FieldOffset(Offset = "0x78")]
	public UIWidget GameSettingPanel;

	[Token(Token = "0x40181BA")]
	[FieldOffset(Offset = "0x7C")]
	public UIButton CreateRoomBtn1;

	[Token(Token = "0x40181BB")]
	[FieldOffset(Offset = "0x80")]
	public GameObject RoundCountGo;

	[Token(Token = "0x40181BC")]
	[FieldOffset(Offset = "0x84")]
	public GameObject GameTimeGo;

	[Token(Token = "0x40181BD")]
	[FieldOffset(Offset = "0x88")]
	public GameObject CheckGo;

	[Token(Token = "0x40181BE")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject UIRoomCheckTemplate1;

	[Token(Token = "0x40181BF")]
	[FieldOffset(Offset = "0x90")]
	public GameObject UIRoomCheckTemplate2;

	[Token(Token = "0x40181C0")]
	[FieldOffset(Offset = "0x94")]
	public GameObject UIRoomCheckTemplate3;

	[Token(Token = "0x40181C1")]
	[FieldOffset(Offset = "0x98")]
	public GameObject UIRoomCheckTemplate4;

	[Token(Token = "0x40181C2")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject UIRoomCheckTemplate5;

	[Token(Token = "0x40181C3")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject UIRoomCheckTemplate6;

	[Token(Token = "0x40181C4")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject UIRoomCheckTemplate7;

	[Token(Token = "0x40181C5")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject UIRoomCheckTemplate8;

	[Token(Token = "0x40181C6")]
	[FieldOffset(Offset = "0xAC")]
	public UIPanel GameSettingMaskPanel;

	[Token(Token = "0x40181C7")]
	[FieldOffset(Offset = "0xB0")]
	public UIButton GameSettingMask;

	[Token(Token = "0x40181C8")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject RoomCardGo;

	[Token(Token = "0x601704E")]
	[Address(RVA = "0x142F938", Offset = "0x142F938", VA = "0x142F938")]
	public UIRushingPetsCreateRoomView()
	{
	}

	[Token(Token = "0x601704F")]
	[Address(RVA = "0x142F940", Offset = "0x142F940", VA = "0x142F940", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017050")]
	[Address(RVA = "0x1430934", Offset = "0x1430934", VA = "0x1430934")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
