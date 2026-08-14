using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037F8")]
public class UIIngameShowSettingView : UIBaseView
{
	[Token(Token = "0x4016BAC")]
	[FieldOffset(Offset = "0x14")]
	public UITable Table;

	[Token(Token = "0x4016BAD")]
	[FieldOffset(Offset = "0x18")]
	public GameObject extraLine;

	[Token(Token = "0x4016BAE")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggle LowestQualityToggle;

	[Token(Token = "0x4016BAF")]
	[FieldOffset(Offset = "0x20")]
	public UIToggle LowQualityToggle;

	[Token(Token = "0x4016BB0")]
	[FieldOffset(Offset = "0x24")]
	public UIToggle HighQualityToggle;

	[Token(Token = "0x4016BB1")]
	[FieldOffset(Offset = "0x28")]
	public UIWidget ExtraQualitySetting;

	[Token(Token = "0x4016BB2")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject HightFPSGO;

	[Token(Token = "0x4016BB3")]
	[FieldOffset(Offset = "0x30")]
	public UISettingToggleGroup HighFPSToggleGroup;

	[Token(Token = "0x4016BB4")]
	[FieldOffset(Offset = "0x34")]
	public UIToggle HighFPS_off;

	[Token(Token = "0x4016BB5")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ShadowGO;

	[Token(Token = "0x4016BB6")]
	[FieldOffset(Offset = "0x3C")]
	public UISettingToggleGroup ShadowOpToggleGroup;

	[Token(Token = "0x4016BB7")]
	[FieldOffset(Offset = "0x40")]
	public UIToggle NorthUpBtn;

	[Token(Token = "0x4016BB8")]
	[FieldOffset(Offset = "0x44")]
	public UIToggle ViewUpBtn;

	[Token(Token = "0x4016BB9")]
	[FieldOffset(Offset = "0x48")]
	public UIToggleButtonGroup MiniMapScaleAssist;

	[Token(Token = "0x4016BBA")]
	[FieldOffset(Offset = "0x4C")]
	public UIToggleButton MiniMapScaleOff;

	[Token(Token = "0x4016BBB")]
	[FieldOffset(Offset = "0x50")]
	public UIToggleButton MiniMapScaleOn;

	[Token(Token = "0x4016BBC")]
	[FieldOffset(Offset = "0x54")]
	public UITable ShowInfo;

	[Token(Token = "0x4016BBD")]
	[FieldOffset(Offset = "0x58")]
	public GameObject UseAuxAim;

	[Token(Token = "0x4016BBE")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject DamageSetting;

	[Token(Token = "0x4016BBF")]
	[FieldOffset(Offset = "0x60")]
	public UIToggle DamageOn;

	[Token(Token = "0x4016BC0")]
	[FieldOffset(Offset = "0x64")]
	public UIToggle DamageOff;

	[Token(Token = "0x4016BC1")]
	[FieldOffset(Offset = "0x68")]
	public UISettingToggleGroup IngameTipsToggleGroup;

	[Token(Token = "0x4016BC2")]
	[FieldOffset(Offset = "0x6C")]
	public UIToggleButtonGroup HitHint;

	[Token(Token = "0x4016BC3")]
	[FieldOffset(Offset = "0x70")]
	public UIToggleButton HitHintEnhanced;

	[Token(Token = "0x4016BC4")]
	[FieldOffset(Offset = "0x74")]
	public UIToggleButton HitHintClassic;

	[Token(Token = "0x6016B93")]
	[Address(RVA = "0x127ACD8", Offset = "0x127ACD8", VA = "0x127ACD8")]
	public UIIngameShowSettingView()
	{
	}

	[Token(Token = "0x6016B94")]
	[Address(RVA = "0x127ACE0", Offset = "0x127ACE0", VA = "0x127ACE0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B95")]
	[Address(RVA = "0x127B564", Offset = "0x127B564", VA = "0x127B564")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
