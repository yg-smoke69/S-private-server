using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037BB")]
public class UIHudUGCMultiTeamMatchResultView : UIBaseView
{
	[Token(Token = "0x4016933")]
	[FieldOffset(Offset = "0x14")]
	public Animator HudNormalMatchResAni;

	[Token(Token = "0x4016934")]
	[FieldOffset(Offset = "0x18")]
	public UILabel RankNum;

	[Token(Token = "0x4016935")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TotalNum;

	[Token(Token = "0x4016936")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ResultDesc;

	[Token(Token = "0x4016937")]
	[FieldOffset(Offset = "0x24")]
	public Transform BaseReward;

	[Token(Token = "0x4016938")]
	[FieldOffset(Offset = "0x28")]
	public UILabel GameModeTxt;

	[Token(Token = "0x4016939")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel GameMapTxt;

	[Token(Token = "0x401693A")]
	[FieldOffset(Offset = "0x30")]
	public GameObject WorkShopGo;

	[Token(Token = "0x401693B")]
	[FieldOffset(Offset = "0x34")]
	public GameObject BiaoQianOB;

	[Token(Token = "0x401693C")]
	[FieldOffset(Offset = "0x38")]
	public UIWidget Biaoqian1;

	[Token(Token = "0x401693D")]
	[FieldOffset(Offset = "0x3C")]
	public UIWidget Biaoqian2;

	[Token(Token = "0x401693E")]
	[FieldOffset(Offset = "0x40")]
	public UIWidget Biaoqian3;

	[Token(Token = "0x401693F")]
	[FieldOffset(Offset = "0x44")]
	public UIWidget Biaoqian4;

	[Token(Token = "0x4016940")]
	[FieldOffset(Offset = "0x48")]
	public UIWidget PlaceHolderBiaoqian;

	[Token(Token = "0x4016941")]
	[FieldOffset(Offset = "0x4C")]
	public UIEasyList EasyListView;

	[Token(Token = "0x4016942")]
	[FieldOffset(Offset = "0x50")]
	public UIButton ShareBtn;

	[Token(Token = "0x4016943")]
	[FieldOffset(Offset = "0x54")]
	public UIButton NextBtn;

	[Token(Token = "0x4016944")]
	[FieldOffset(Offset = "0x58")]
	public UILabel NextBtnTime;

	[Token(Token = "0x4016945")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel NextBtnLable;

	[Token(Token = "0x4016946")]
	[FieldOffset(Offset = "0x60")]
	public UIButton DetailsBtn;

	[Token(Token = "0x4016947")]
	[FieldOffset(Offset = "0x64")]
	public GameObject DetailBtnShowIcon;

	[Token(Token = "0x4016948")]
	[FieldOffset(Offset = "0x68")]
	public GameObject DetailBtnHideIcon;

	[Token(Token = "0x4016949")]
	[FieldOffset(Offset = "0x6C")]
	public UIButton ReplayBtn;

	[Token(Token = "0x401694A")]
	[FieldOffset(Offset = "0x70")]
	public UILabel ReplayTips;

	[Token(Token = "0x401694B")]
	[FieldOffset(Offset = "0x74")]
	public UIGrid RewardBtnGrid;

	[Token(Token = "0x401694C")]
	[FieldOffset(Offset = "0x78")]
	public UIButton VideoGiftBtn;

	[Token(Token = "0x401694D")]
	[FieldOffset(Offset = "0x7C")]
	public UIButton FastSendGiftBtn;

	[Token(Token = "0x401694E")]
	[FieldOffset(Offset = "0x80")]
	public Transform CallSignContainer;

	[Token(Token = "0x401694F")]
	[FieldOffset(Offset = "0x84")]
	public GameObject ShareInfoContainer;

	[Token(Token = "0x4016950")]
	[FieldOffset(Offset = "0x88")]
	public UILabel ShareGameModeTxt;

	[Token(Token = "0x4016951")]
	[FieldOffset(Offset = "0x8C")]
	public UIWidget Biaoqian1Share;

	[Token(Token = "0x4016952")]
	[FieldOffset(Offset = "0x90")]
	public UIWidget Biaoqian2Share;

	[Token(Token = "0x4016953")]
	[FieldOffset(Offset = "0x94")]
	public UIWidget Biaoqian3Share;

	[Token(Token = "0x4016954")]
	[FieldOffset(Offset = "0x98")]
	public UIWidget Biaoqian4Share;

	[Token(Token = "0x4016955")]
	[FieldOffset(Offset = "0x9C")]
	public UITable BottomLeftTable;

	[Token(Token = "0x6016ADC")]
	[Address(RVA = "0x1A64B88", Offset = "0x1A64B88", VA = "0x1A64B88")]
	public UIHudUGCMultiTeamMatchResultView()
	{
	}

	[Token(Token = "0x6016ADD")]
	[Address(RVA = "0x1A64B90", Offset = "0x1A64B90", VA = "0x1A64B90", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016ADE")]
	[Address(RVA = "0x1A6596C", Offset = "0x1A6596C", VA = "0x1A6596C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
