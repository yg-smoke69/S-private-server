using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003539")]
public class UIFlashStoreActivityPhaseNodeView : UIBaseView
{
	[Token(Token = "0x40150BB")]
	[FieldOffset(Offset = "0x14")]
	public GameObject OverdueGroup;

	[Token(Token = "0x40150BC")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ProceedingGroup;

	[Token(Token = "0x40150BD")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject LockedGroup;

	[Token(Token = "0x40150BE")]
	[FieldOffset(Offset = "0x20")]
	public UILabel OverdueDateLabel;

	[Token(Token = "0x40150BF")]
	[FieldOffset(Offset = "0x24")]
	public UILabel ProceedingLabel;

	[Token(Token = "0x40150C0")]
	[FieldOffset(Offset = "0x28")]
	public UICountDownLabel ProceedingCountdownLabel;

	[Token(Token = "0x40150C1")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel LockedDateLabel;

	[Token(Token = "0x40150C2")]
	[FieldOffset(Offset = "0x30")]
	public UIButton ActionBtn;

	[Token(Token = "0x40150C3")]
	[FieldOffset(Offset = "0x34")]
	public GameObject SelectedIcon;

	[Token(Token = "0x40150C4")]
	[FieldOffset(Offset = "0x38")]
	public GameObject OverdueContent;

	[Token(Token = "0x40150C5")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ProceedingContent;

	[Token(Token = "0x40150C6")]
	[FieldOffset(Offset = "0x40")]
	public GameObject LockedContent;

	[Token(Token = "0x40150C7")]
	[FieldOffset(Offset = "0x44")]
	public UILabel ProceedingDescLabel;

	[Token(Token = "0x40150C8")]
	[FieldOffset(Offset = "0x48")]
	public UILabel OverdueDescLabel;

	[Token(Token = "0x40150C9")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite ProceedingTimeIcon;

	[Token(Token = "0x40150CA")]
	[FieldOffset(Offset = "0x50")]
	public UIWidget GuideWidget;

	[Token(Token = "0x601635B")]
	[Address(RVA = "0x1DD0498", Offset = "0x1DD0498", VA = "0x1DD0498")]
	public UIFlashStoreActivityPhaseNodeView()
	{
	}

	[Token(Token = "0x601635C")]
	[Address(RVA = "0x1DD04A0", Offset = "0x1DD04A0", VA = "0x1DD04A0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601635D")]
	[Address(RVA = "0x1DD0B94", Offset = "0x1DD0B94", VA = "0x1DD0B94")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
