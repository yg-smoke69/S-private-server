using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033CE")]
public class UIAvatarLinkView : UIBaseView
{
	[Token(Token = "0x4013CFD")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ProgressPanel;

	[Token(Token = "0x4013CFE")]
	[FieldOffset(Offset = "0x18")]
	public UISlider ProgressSlider;

	[Token(Token = "0x4013CFF")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LinkWithAvatarNameLabel;

	[Token(Token = "0x4013D00")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LinkProgressLabel;

	[Token(Token = "0x4013D01")]
	[FieldOffset(Offset = "0x24")]
	public GameObject AcquisitionPanel;

	[Token(Token = "0x4013D02")]
	[FieldOffset(Offset = "0x28")]
	public UILabel AcquisitionTitle;

	[Token(Token = "0x4013D03")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton AcquisitionHelpBtn;

	[Token(Token = "0x4013D04")]
	[FieldOffset(Offset = "0x30")]
	public UILabel PlayGameDescription;

	[Token(Token = "0x4013D05")]
	[FieldOffset(Offset = "0x34")]
	public UILabel PlayGameProgressLabel;

	[Token(Token = "0x4013D06")]
	[FieldOffset(Offset = "0x38")]
	public UIButton PlayGameBtn;

	[Token(Token = "0x4013D07")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel PlayGameBtnLabel;

	[Token(Token = "0x4013D08")]
	[FieldOffset(Offset = "0x40")]
	public UILabel DonateLimitLabel;

	[Token(Token = "0x4013D09")]
	[FieldOffset(Offset = "0x44")]
	public UILabel DonateCompleteLabel;

	[Token(Token = "0x4013D0A")]
	[FieldOffset(Offset = "0x48")]
	public UIButton DonateBtn;

	[Token(Token = "0x4013D0B")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel DonateBtnLabel;

	[Token(Token = "0x4013D0C")]
	[FieldOffset(Offset = "0x50")]
	public UILabel CooldownInfo;

	[Token(Token = "0x4013D0D")]
	[FieldOffset(Offset = "0x54")]
	public GameObject SkillPanel;

	[Token(Token = "0x4013D0E")]
	[FieldOffset(Offset = "0x58")]
	public UIButton SkillHelpBtn;

	[Token(Token = "0x4013D0F")]
	[FieldOffset(Offset = "0x5C")]
	public Transform SkillSlotTrans;

	[Token(Token = "0x4013D10")]
	[FieldOffset(Offset = "0x60")]
	public UILabel SkillNameLabel;

	[Token(Token = "0x4013D11")]
	[FieldOffset(Offset = "0x64")]
	public UILabel SkillTypeLabel;

	[Token(Token = "0x4013D12")]
	[FieldOffset(Offset = "0x68")]
	public UILabel SkillDescLabel;

	[Token(Token = "0x4013D13")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject ActionPanel;

	[Token(Token = "0x4013D14")]
	[FieldOffset(Offset = "0x70")]
	public UIButton ActionBtn;

	[Token(Token = "0x4013D15")]
	[FieldOffset(Offset = "0x74")]
	public UISprite GuideStep4Widget;

	[Token(Token = "0x4013D16")]
	[FieldOffset(Offset = "0x78")]
	public UILabel ActionBtnLabel;

	[Token(Token = "0x4013D17")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject GameObjectLinkSelectPanel;

	[Token(Token = "0x4013D18")]
	[FieldOffset(Offset = "0x80")]
	public TweenPosition TweenPositionLinkSelectPanel;

	[Token(Token = "0x4013D19")]
	[FieldOffset(Offset = "0x84")]
	public UIButton ExpandCollapseBtn;

	[Token(Token = "0x4013D1A")]
	[FieldOffset(Offset = "0x88")]
	public GameObject ExpandIcon;

	[Token(Token = "0x4013D1B")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject CollapseIcon;

	[Token(Token = "0x4013D1C")]
	[FieldOffset(Offset = "0x90")]
	public GameObject TipsIcon;

	[Token(Token = "0x4013D1D")]
	[FieldOffset(Offset = "0x94")]
	public UIScrollView LinkInfoScrollView;

	[Token(Token = "0x4013D1E")]
	[FieldOffset(Offset = "0x98")]
	public UIEasyList LinkInfoEasyList;

	[Token(Token = "0x4013D1F")]
	[FieldOffset(Offset = "0x9C")]
	public UILabel LinkInfoTitleLabel;

	[Token(Token = "0x4013D20")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject AvatarSkillPanel;

	[Token(Token = "0x4013D21")]
	[FieldOffset(Offset = "0xA4")]
	public UISprite AvatarSkillIcon;

	[Token(Token = "0x4013D22")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject NoLinkedPanel;

	[Token(Token = "0x4013D23")]
	[FieldOffset(Offset = "0xAC")]
	public UIButton NoLinkedBtn;

	[Token(Token = "0x4013D24")]
	[FieldOffset(Offset = "0xB0")]
	public UISprite NoLinkedSprite;

	[Token(Token = "0x4013D25")]
	[FieldOffset(Offset = "0xB4")]
	public UILabel NoLinkedDescLabel;

	[Token(Token = "0x4013D26")]
	[FieldOffset(Offset = "0xB8")]
	public TweenPosition CenterPanel;

	[Token(Token = "0x4013D27")]
	[FieldOffset(Offset = "0xBC")]
	public UIScrollView SkillDescScrollView;

	[Token(Token = "0x4013D28")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel NoLinkedCountdownLabel;

	[Token(Token = "0x4013D29")]
	[FieldOffset(Offset = "0xC4")]
	public UILabel BubbleLabel;

	[Token(Token = "0x4013D2A")]
	[FieldOffset(Offset = "0xC8")]
	public UIButton DisabledActionBtn;

	[Token(Token = "0x4013D2B")]
	[FieldOffset(Offset = "0xCC")]
	public UILabel DisabledActionBtnLabel;

	[Token(Token = "0x4013D2C")]
	[FieldOffset(Offset = "0xD0")]
	public UIWidget GuideStep2;

	[Token(Token = "0x4013D2D")]
	[FieldOffset(Offset = "0xD4")]
	public UIPanel GuidePanel;

	[Token(Token = "0x4013D2E")]
	[FieldOffset(Offset = "0xD8")]
	public UIButton GuideMask;

	[Token(Token = "0x4013D2F")]
	[FieldOffset(Offset = "0xDC")]
	public UIPanel LoopVFXClipPanel;

	[Token(Token = "0x4013D30")]
	[FieldOffset(Offset = "0xE0")]
	public UIColor ProgressWidget;

	[Token(Token = "0x4013D31")]
	[FieldOffset(Offset = "0xE4")]
	public GameObject ProgressIncreaseVFX;

	[Token(Token = "0x4013D32")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject ActionBtnVFX;

	[Token(Token = "0x4013D33")]
	[FieldOffset(Offset = "0xEC")]
	public GameObject LinkToProgressVFXTrail;

	[Token(Token = "0x4013D34")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject LinkToProgressVFXEnd;

	[Token(Token = "0x4013D35")]
	[FieldOffset(Offset = "0xF4")]
	public UIPanel ClipPanel;

	[Token(Token = "0x4013D36")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject BubblePanel;

	[Token(Token = "0x4013D37")]
	[FieldOffset(Offset = "0xFC")]
	public Animation BubblePanelAnim;

	[Token(Token = "0x4013D38")]
	[FieldOffset(Offset = "0x100")]
	public Transform PlayGameDescEmptyTrans;

	[Token(Token = "0x4013D39")]
	[FieldOffset(Offset = "0x104")]
	public Transform PlayGameDescPreviewTrans;

	[Token(Token = "0x4013D3A")]
	[FieldOffset(Offset = "0x108")]
	public Transform RightPanelStartupTrans;

	[Token(Token = "0x4013D3B")]
	[FieldOffset(Offset = "0x10C")]
	public Transform RightPanelExpandTrans;

	[Token(Token = "0x4013D3C")]
	[FieldOffset(Offset = "0x110")]
	public Transform RightPanelCollapseTrans;

	[Token(Token = "0x4013D3D")]
	[FieldOffset(Offset = "0x114")]
	public Transform RightPanel;

	[Token(Token = "0x4013D3E")]
	[FieldOffset(Offset = "0x118")]
	public TweenPosition RightPanelTweenPos;

	[Token(Token = "0x4013D3F")]
	[FieldOffset(Offset = "0x11C")]
	public UILabel DonateLinkAmountLabel;

	[Token(Token = "0x4013D40")]
	[FieldOffset(Offset = "0x120")]
	public GameObject LinkInfoTitleIcon;

	[Token(Token = "0x4013D41")]
	[FieldOffset(Offset = "0x124")]
	public UILabel NoticeLabel;

	[Token(Token = "0x4013D42")]
	[FieldOffset(Offset = "0x128")]
	public UILabel DonateDescription;

	[Token(Token = "0x4013D43")]
	[FieldOffset(Offset = "0x12C")]
	public Transform DonateDescEmptyTrans;

	[Token(Token = "0x4013D44")]
	[FieldOffset(Offset = "0x130")]
	public Transform DonateDescPreviewTrans;

	[Token(Token = "0x4013D45")]
	[FieldOffset(Offset = "0x134")]
	public Animation LinkWithPanelAnim;

	[Token(Token = "0x4013D46")]
	[FieldOffset(Offset = "0x138")]
	public Transform DownloadTrRoot;

	[Token(Token = "0x4013D47")]
	[FieldOffset(Offset = "0x13C")]
	public Transform SkillTipsTrans;

	[Token(Token = "0x4013D48")]
	[FieldOffset(Offset = "0x140")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x6015F20")]
	[Address(RVA = "0x2A9AC1C", Offset = "0x2A9AC1C", VA = "0x2A9AC1C")]
	public UIAvatarLinkView()
	{
	}

	[Token(Token = "0x6015F21")]
	[Address(RVA = "0x2A9AC24", Offset = "0x2A9AC24", VA = "0x2A9AC24", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F22")]
	[Address(RVA = "0x2A9C774", Offset = "0x2A9C774", VA = "0x2A9C774")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
