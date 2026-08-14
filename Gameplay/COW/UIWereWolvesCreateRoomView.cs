using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A81")]
public class UIWereWolvesCreateRoomView : UIBaseView
{
	[Token(Token = "0x4018DAB")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel TopPanel;

	[Token(Token = "0x4018DAC")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x4018DAD")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject RoomGameSettingBtnGo;

	[Token(Token = "0x4018DAE")]
	[FieldOffset(Offset = "0x20")]
	public UIButton close;

	[Token(Token = "0x4018DAF")]
	[FieldOffset(Offset = "0x24")]
	public GameObject InfoPanel;

	[Token(Token = "0x4018DB0")]
	[FieldOffset(Offset = "0x28")]
	public UIWidget RoomSettingPanel;

	[Token(Token = "0x4018DB1")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Map;

	[Token(Token = "0x4018DB2")]
	[FieldOffset(Offset = "0x30")]
	public UILabel MapName;

	[Token(Token = "0x4018DB3")]
	[FieldOffset(Offset = "0x34")]
	public UIInput NameInput;

	[Token(Token = "0x4018DB4")]
	[FieldOffset(Offset = "0x38")]
	public UIInput CodeInput;

	[Token(Token = "0x4018DB5")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject PlayerCountSettingRoot;

	[Token(Token = "0x4018DB6")]
	[FieldOffset(Offset = "0x40")]
	public UILabel SettingPagePlayerCountLabel;

	[Token(Token = "0x4018DB7")]
	[FieldOffset(Offset = "0x44")]
	public UIWidget PlayerCountPopMenu;

	[Token(Token = "0x4018DB8")]
	[FieldOffset(Offset = "0x48")]
	public UIWidget WolfCountPopMenu;

	[Token(Token = "0x4018DB9")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton CreateRoomBtn2;

	[Token(Token = "0x4018DBA")]
	[FieldOffset(Offset = "0x50")]
	public UIButton LanguageBtn;

	[Token(Token = "0x4018DBB")]
	[FieldOffset(Offset = "0x54")]
	public UISprite LanguageSprite;

	[Token(Token = "0x4018DBC")]
	[FieldOffset(Offset = "0x58")]
	public GameObject LanguagaeCreateRoot;

	[Token(Token = "0x4018DBD")]
	[FieldOffset(Offset = "0x5C")]
	public UIPanel RoomSettingMaskPanel;

	[Token(Token = "0x4018DBE")]
	[FieldOffset(Offset = "0x60")]
	public UIButton RoomSettingMask;

	[Token(Token = "0x4018DBF")]
	[FieldOffset(Offset = "0x64")]
	public UIWidget GameSettingPanel;

	[Token(Token = "0x4018DC0")]
	[FieldOffset(Offset = "0x68")]
	public UIButton CreateRoomBtn1;

	[Token(Token = "0x4018DC1")]
	[FieldOffset(Offset = "0x6C")]
	public UIButton ResetBtn;

	[Token(Token = "0x4018DC2")]
	[FieldOffset(Offset = "0x70")]
	public UIToggleButton TrapOnBtn;

	[Token(Token = "0x4018DC3")]
	[FieldOffset(Offset = "0x74")]
	public UIToggleButton TrapOffBtn;

	[Token(Token = "0x4018DC4")]
	[FieldOffset(Offset = "0x78")]
	public UIToggleButton PredictOnBtn;

	[Token(Token = "0x4018DC5")]
	[FieldOffset(Offset = "0x7C")]
	public UIToggleButton PredictOffBtn;

	[Token(Token = "0x4018DC6")]
	[FieldOffset(Offset = "0x80")]
	public UIGrid ParamsGrid;

	[Token(Token = "0x4018DC7")]
	[FieldOffset(Offset = "0x84")]
	public UIPanel GameSettingMaskPanel;

	[Token(Token = "0x4018DC8")]
	[FieldOffset(Offset = "0x88")]
	public UIButton GameSettingMask;

	[Token(Token = "0x4018DC9")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject RoomCardGo;

	[Token(Token = "0x6017329")]
	[Address(RVA = "0x1B80BA4", Offset = "0x1B80BA4", VA = "0x1B80BA4")]
	public UIWereWolvesCreateRoomView()
	{
	}

	[Token(Token = "0x601732A")]
	[Address(RVA = "0x1B80BAC", Offset = "0x1B80BAC", VA = "0x1B80BAC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601732B")]
	[Address(RVA = "0x1B81858", Offset = "0x1B81858", VA = "0x1B81858")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
