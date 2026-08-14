using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003724")]
public class UIHudSceneEditAdjustFloorPlaneView : UIBaseView
{
	[Token(Token = "0x40164A9")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnUp;

	[Token(Token = "0x40164AA")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BtnUpIcon;

	[Token(Token = "0x40164AB")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnDown;

	[Token(Token = "0x40164AC")]
	[FieldOffset(Offset = "0x20")]
	public UISprite BtnDownIcon;

	[Token(Token = "0x40164AD")]
	[FieldOffset(Offset = "0x24")]
	public UILabel FloorNumLabel;

	[Token(Token = "0x40164AE")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnIcon;

	[Token(Token = "0x40164AF")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Icon;

	[Token(Token = "0x40164B0")]
	[FieldOffset(Offset = "0x30")]
	public GameObject SubPanel;

	[Token(Token = "0x6016917")]
	[Address(RVA = "0x1C53DB0", Offset = "0x1C53DB0", VA = "0x1C53DB0")]
	public UIHudSceneEditAdjustFloorPlaneView()
	{
	}

	[Token(Token = "0x6016918")]
	[Address(RVA = "0x1C53DB8", Offset = "0x1C53DB8", VA = "0x1C53DB8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016919")]
	[Address(RVA = "0x1C541F4", Offset = "0x1C541F4", VA = "0x1C541F4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
