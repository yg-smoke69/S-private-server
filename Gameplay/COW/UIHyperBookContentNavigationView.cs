using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037ED")]
public class UIHyperBookContentNavigationView : UIBaseView
{
	[Token(Token = "0x4016AEA")]
	[FieldOffset(Offset = "0x14")]
	public GameObject BookPageDetailsPanel;

	[Token(Token = "0x4016AEB")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BookPageDetailsBG;

	[Token(Token = "0x4016AEC")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel PageIndexLabel;

	[Token(Token = "0x4016AED")]
	[FieldOffset(Offset = "0x20")]
	public UIButton PageHelpBtn;

	[Token(Token = "0x4016AEE")]
	[FieldOffset(Offset = "0x24")]
	public UILabel PageDetailsLabel;

	[Token(Token = "0x4016AEF")]
	[FieldOffset(Offset = "0x28")]
	public GameObject FunctionWidget;

	[Token(Token = "0x4016AF0")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton FunctionBtn;

	[Token(Token = "0x4016AF1")]
	[FieldOffset(Offset = "0x30")]
	public UILabel FunctionBtnLabel;

	[Token(Token = "0x4016AF2")]
	[FieldOffset(Offset = "0x34")]
	public UILabel RemainSpinCountLabel;

	[Token(Token = "0x4016AF3")]
	[FieldOffset(Offset = "0x38")]
	public GameObject UnlockProgressGroup;

	[Token(Token = "0x4016AF4")]
	[FieldOffset(Offset = "0x3C")]
	public UICenterTargetHelper UnlockProgressGroupHelper;

	[Token(Token = "0x4016AF5")]
	[FieldOffset(Offset = "0x40")]
	public UILabel UnlockProgessTokenLabel;

	[Token(Token = "0x4016AF6")]
	[FieldOffset(Offset = "0x44")]
	public UISprite UnlockProgressTokenIcon;

	[Token(Token = "0x4016AF7")]
	[FieldOffset(Offset = "0x48")]
	public UIButton GotoLockedPageBtn;

	[Token(Token = "0x4016AF8")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel GotoLockedPageLabel;

	[Token(Token = "0x4016AF9")]
	[FieldOffset(Offset = "0x50")]
	public UIGrid BookProgressPageGrid;

	[Token(Token = "0x4016AFA")]
	[FieldOffset(Offset = "0x54")]
	public UIWidget PreviewBorderWidget;

	[Token(Token = "0x4016AFB")]
	[FieldOffset(Offset = "0x58")]
	public UICenterTargetHelper PageDetailsTitleGroup;

	[Token(Token = "0x4016AFC")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton GotoStoreBtn;

	[Token(Token = "0x4016AFD")]
	[FieldOffset(Offset = "0x60")]
	public GameObject NormalPageDecoLine;

	[Token(Token = "0x4016AFE")]
	[FieldOffset(Offset = "0x64")]
	public GameObject HiddenPageDecoLine;

	[Token(Token = "0x4016AFF")]
	[FieldOffset(Offset = "0x68")]
	public GameObject GuideMaskPanel;

	[Token(Token = "0x4016B00")]
	[FieldOffset(Offset = "0x6C")]
	public UIButton GuideMask;

	[Token(Token = "0x4016B01")]
	[FieldOffset(Offset = "0x70")]
	public Animation OnNaviPushAnim;

	[Token(Token = "0x4016B02")]
	[FieldOffset(Offset = "0x74")]
	public GameObject PreviewChangedVFX;

	[Token(Token = "0x4016B03")]
	[FieldOffset(Offset = "0x78")]
	public GameObject PageUnlockVFX;

	[Token(Token = "0x4016B04")]
	[FieldOffset(Offset = "0x7C")]
	public Animation PageUnlockAnim;

	[Token(Token = "0x4016B05")]
	[FieldOffset(Offset = "0x80")]
	public GameObject TurnNextPageVFX;

	[Token(Token = "0x4016B06")]
	[FieldOffset(Offset = "0x84")]
	public GameObject TurnPreviousPageVFX;

	[Token(Token = "0x4016B07")]
	[FieldOffset(Offset = "0x88")]
	public GameObject ParticleGatheringVFX;

	[Token(Token = "0x4016B08")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel DebugBookModelContentLabel;

	[Token(Token = "0x6016B72")]
	[Address(RVA = "0x29552C0", Offset = "0x29552C0", VA = "0x29552C0")]
	public UIHyperBookContentNavigationView()
	{
	}

	[Token(Token = "0x6016B73")]
	[Address(RVA = "0x29552C8", Offset = "0x29552C8", VA = "0x29552C8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B74")]
	[Address(RVA = "0x2955F2C", Offset = "0x2955F2C", VA = "0x2955F2C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
