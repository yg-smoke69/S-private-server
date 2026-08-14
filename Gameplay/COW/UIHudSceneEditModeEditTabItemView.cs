using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003733")]
public class UIHudSceneEditModeEditTabItemView : UIBaseView
{
	[Token(Token = "0x40164FD")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIHudSceneEditModeEditTabItem;

	[Token(Token = "0x40164FE")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelUniversal;

	[Token(Token = "0x40164FF")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelUniversalUnSelected;

	[Token(Token = "0x4016500")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SpriteUniversalSelected;

	[Token(Token = "0x6016944")]
	[Address(RVA = "0x24DF8C8", Offset = "0x24DF8C8", VA = "0x24DF8C8")]
	public UIHudSceneEditModeEditTabItemView()
	{
	}

	[Token(Token = "0x6016945")]
	[Address(RVA = "0x24DF8D0", Offset = "0x24DF8D0", VA = "0x24DF8D0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016946")]
	[Address(RVA = "0x24DFB8C", Offset = "0x24DFB8C", VA = "0x24DFB8C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
