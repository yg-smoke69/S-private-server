using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003538")]
public class UIFlashStoreActivityNavigationView : UIBaseView
{
	[Token(Token = "0x40150AF")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTexture TitleCDN;

	[Token(Token = "0x40150B0")]
	[FieldOffset(Offset = "0x18")]
	public UIButton RuleBtn;

	[Token(Token = "0x40150B1")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TitleDescriptionLabel;

	[Token(Token = "0x40150B2")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ActivitiesPanelDescLabel;

	[Token(Token = "0x40150B3")]
	[FieldOffset(Offset = "0x24")]
	public UIScrollView ActivitiesScrollView;

	[Token(Token = "0x40150B4")]
	[FieldOffset(Offset = "0x28")]
	public UITable ActivitiesTable;

	[Token(Token = "0x40150B5")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid ProgressPointGrid;

	[Token(Token = "0x40150B6")]
	[FieldOffset(Offset = "0x30")]
	public UISlider ProgressSlider;

	[Token(Token = "0x40150B7")]
	[FieldOffset(Offset = "0x34")]
	public UIButton ReceiveAllBtn;

	[Token(Token = "0x40150B8")]
	[FieldOffset(Offset = "0x38")]
	public GameObject TitleDefaultIcon;

	[Token(Token = "0x40150B9")]
	[FieldOffset(Offset = "0x3C")]
	public UIPanel GuideMaskPanel;

	[Token(Token = "0x40150BA")]
	[FieldOffset(Offset = "0x40")]
	public UIButton GuideMask;

	[Token(Token = "0x6016358")]
	[Address(RVA = "0x1DCE874", Offset = "0x1DCE874", VA = "0x1DCE874")]
	public UIFlashStoreActivityNavigationView()
	{
	}

	[Token(Token = "0x6016359")]
	[Address(RVA = "0x1DCE87C", Offset = "0x1DCE87C", VA = "0x1DCE87C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601635A")]
	[Address(RVA = "0x1DCEE38", Offset = "0x1DCEE38", VA = "0x1DCEE38")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
