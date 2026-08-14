using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003586")]
public class UIGachaLimitChestContentView : UIBaseView
{
	[Token(Token = "0x401544B")]
	[FieldOffset(Offset = "0x14")]
	public Animator LeftPageAni;

	[Token(Token = "0x401544C")]
	[FieldOffset(Offset = "0x18")]
	public UITable Table;

	[Token(Token = "0x401544D")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton ProbabilityTips;

	[Token(Token = "0x401544E")]
	[FieldOffset(Offset = "0x20")]
	public GameObject CountDownContent;

	[Token(Token = "0x401544F")]
	[FieldOffset(Offset = "0x24")]
	public UICountDownIcon CountDownIcon;

	[Token(Token = "0x4015450")]
	[FieldOffset(Offset = "0x28")]
	public UICountDownLabel GachaCountDownLabel;

	[Token(Token = "0x4015451")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject BGMask;

	[Token(Token = "0x4015452")]
	[FieldOffset(Offset = "0x30")]
	public GameObject UnselectedNode;

	[Token(Token = "0x4015453")]
	[FieldOffset(Offset = "0x34")]
	public UILabel DescLabel;

	[Token(Token = "0x4015454")]
	[FieldOffset(Offset = "0x38")]
	public UIToggleButton Toggle1;

	[Token(Token = "0x4015455")]
	[FieldOffset(Offset = "0x3C")]
	public UIToggleButton Toggle2;

	[Token(Token = "0x4015456")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Reward1;

	[Token(Token = "0x4015457")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Reward2;

	[Token(Token = "0x4015458")]
	[FieldOffset(Offset = "0x48")]
	public GameObject Reward3;

	[Token(Token = "0x4015459")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject Reward4;

	[Token(Token = "0x401545A")]
	[FieldOffset(Offset = "0x50")]
	public GameObject Reward5;

	[Token(Token = "0x401545B")]
	[FieldOffset(Offset = "0x54")]
	public GameObject Reward6;

	[Token(Token = "0x401545C")]
	[FieldOffset(Offset = "0x58")]
	public GameObject Selected;

	[Token(Token = "0x401545D")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton NextBtn;

	[Token(Token = "0x401545E")]
	[FieldOffset(Offset = "0x60")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x401545F")]
	[FieldOffset(Offset = "0x64")]
	public GameObject LimitTurnTableName;

	[Token(Token = "0x4015460")]
	[FieldOffset(Offset = "0x68")]
	public UINetworkTexture LimitTitleCDN;

	[Token(Token = "0x4015461")]
	[FieldOffset(Offset = "0x6C")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x4015462")]
	[FieldOffset(Offset = "0x70")]
	public GameObject NormalNode;

	[Token(Token = "0x4015463")]
	[FieldOffset(Offset = "0x74")]
	public GameObject EffectNode;

	[Token(Token = "0x4015464")]
	[FieldOffset(Offset = "0x78")]
	public GameObject DisplayRewardNodes;

	[Token(Token = "0x4015465")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject Node1;

	[Token(Token = "0x4015466")]
	[FieldOffset(Offset = "0x80")]
	public GameObject Node2;

	[Token(Token = "0x4015467")]
	[FieldOffset(Offset = "0x84")]
	public GameObject Node3;

	[Token(Token = "0x4015468")]
	[FieldOffset(Offset = "0x88")]
	public GameObject Node4;

	[Token(Token = "0x4015469")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject Node5;

	[Token(Token = "0x401546A")]
	[FieldOffset(Offset = "0x90")]
	public GameObject Node6;

	[Token(Token = "0x401546B")]
	[FieldOffset(Offset = "0x94")]
	public GameObject SelectedNode;

	[Token(Token = "0x401546C")]
	[FieldOffset(Offset = "0x98")]
	public GameObject BuyBtnNode;

	[Token(Token = "0x401546D")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject AllGetedLabel;

	[Token(Token = "0x401546E")]
	[FieldOffset(Offset = "0xA0")]
	public UISlider Loading;

	[Token(Token = "0x401546F")]
	[FieldOffset(Offset = "0xA4")]
	public UILabel LoadingLabel;

	[Token(Token = "0x4015470")]
	[FieldOffset(Offset = "0xA8")]
	public UICheckboxButton DisplayRewardToggle;

	[Token(Token = "0x4015471")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject VFX_BosComeOutEffect;

	[Token(Token = "0x4015472")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject InterfaceMaskLabel;

	[Token(Token = "0x4015473")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject VFX_SelectRewardPageStartEffect;

	[Token(Token = "0x4015474")]
	[FieldOffset(Offset = "0xB8")]
	public Animator VFX_BoxEffect;

	[Token(Token = "0x4015475")]
	[FieldOffset(Offset = "0xBC")]
	public MeshRenderer BoxEffectMeshRenderer;

	[Token(Token = "0x4015476")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject AniReplayBtnNode;

	[Token(Token = "0x4015477")]
	[FieldOffset(Offset = "0xC4")]
	public UIWidget PreviewBorderBeforeChoose;

	[Token(Token = "0x4015478")]
	[FieldOffset(Offset = "0xC8")]
	public UIWidget PreviewBorderAfterChoose;

	[Token(Token = "0x6016442")]
	[Address(RVA = "0x2E82E94", Offset = "0x2E82E94", VA = "0x2E82E94")]
	public UIGachaLimitChestContentView()
	{
	}

	[Token(Token = "0x6016443")]
	[Address(RVA = "0x2E82E9C", Offset = "0x2E82E9C", VA = "0x2E82E9C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016444")]
	[Address(RVA = "0x2E83FE0", Offset = "0x2E83FE0", VA = "0x2E83FE0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
