using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003722")]
public class UIHudSceneEditActionTypeView : UIBaseView
{
	[Token(Token = "0x401649C")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ActionTypeBtn;

	[Token(Token = "0x401649D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Highlight;

	[Token(Token = "0x401649E")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Icon;

	[Token(Token = "0x401649F")]
	[FieldOffset(Offset = "0x20")]
	public UILabel TypeName;

	[Token(Token = "0x40164A0")]
	[FieldOffset(Offset = "0x24")]
	public UIWidget GuideWidget;

	[Token(Token = "0x6016911")]
	[Address(RVA = "0x1C52858", Offset = "0x1C52858", VA = "0x1C52858")]
	public UIHudSceneEditActionTypeView()
	{
	}

	[Token(Token = "0x6016912")]
	[Address(RVA = "0x1C52860", Offset = "0x1C52860", VA = "0x1C52860", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016913")]
	[Address(RVA = "0x1C52B7C", Offset = "0x1C52B7C", VA = "0x1C52B7C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
