using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034D4")]
public class UIDigitaluniverseBMapDoorMissionItemView : UIBaseView
{
	[Token(Token = "0x4014BA1")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelDesc;

	[Token(Token = "0x4014BA2")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelNum;

	[Token(Token = "0x4014BA3")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite SpriteComplete;

	[Token(Token = "0x4014BA4")]
	[FieldOffset(Offset = "0x20")]
	public UISprite BG;

	[Token(Token = "0x4014BA5")]
	[FieldOffset(Offset = "0x24")]
	public GameObject VFX_sweep;

	[Token(Token = "0x4014BA6")]
	[FieldOffset(Offset = "0x28")]
	public UIEffectWidget VFXSweepEffWidget;

	[Token(Token = "0x4014BA7")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Mask;

	[Token(Token = "0x6016230")]
	[Address(RVA = "0x2F7D020", Offset = "0x2F7D020", VA = "0x2F7D020")]
	public UIDigitaluniverseBMapDoorMissionItemView()
	{
	}

	[Token(Token = "0x6016231")]
	[Address(RVA = "0x2F7D028", Offset = "0x2F7D028", VA = "0x2F7D028", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016232")]
	[Address(RVA = "0x2F7D404", Offset = "0x2F7D404", VA = "0x2F7D404")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
