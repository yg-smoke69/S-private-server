using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036D2")]
public class UIHudPartyNPCInteractDialogView : UIBaseView
{
	[Token(Token = "0x401622A")]
	[FieldOffset(Offset = "0x14")]
	public UIButton CloseMask;

	[Token(Token = "0x401622B")]
	[FieldOffset(Offset = "0x18")]
	public UILabel NPCName;

	[Token(Token = "0x401622C")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel DialogLabel;

	[Token(Token = "0x401622D")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid Grid;

	[Token(Token = "0x401622E")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ClickToCloseLabel;

	[Token(Token = "0x6016823")]
	[Address(RVA = "0x18457F8", Offset = "0x18457F8", VA = "0x18457F8")]
	public UIHudPartyNPCInteractDialogView()
	{
	}

	[Token(Token = "0x6016824")]
	[Address(RVA = "0x1845800", Offset = "0x1845800", VA = "0x1845800", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016825")]
	[Address(RVA = "0x1845A44", Offset = "0x1845A44", VA = "0x1845A44")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
