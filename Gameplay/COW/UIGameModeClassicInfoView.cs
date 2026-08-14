using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035A4")]
public class UIGameModeClassicInfoView : UIBaseView
{
	[Token(Token = "0x4015674")]
	[FieldOffset(Offset = "0x14")]
	public UIButton HelperBtn;

	[Token(Token = "0x4015675")]
	[FieldOffset(Offset = "0x18")]
	public GameObject HelperTipsContainer;

	[Token(Token = "0x4015676")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel HelperTips;

	[Token(Token = "0x4015677")]
	[FieldOffset(Offset = "0x20")]
	public UIButton HelperMaskBtn;

	[Token(Token = "0x4015678")]
	[FieldOffset(Offset = "0x24")]
	public GameObject gray;

	[Token(Token = "0x4015679")]
	[FieldOffset(Offset = "0x28")]
	public UILabel matchMode;

	[Token(Token = "0x401567A")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject MapModeTipsAnim;

	[Token(Token = "0x401567B")]
	[FieldOffset(Offset = "0x30")]
	public UILabel tips;

	[Token(Token = "0x401567C")]
	[FieldOffset(Offset = "0x34")]
	public Transform NormalView;

	[Token(Token = "0x401567D")]
	[FieldOffset(Offset = "0x38")]
	public UILabel gameMode;

	[Token(Token = "0x401567E")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel mapMode;

	[Token(Token = "0x401567F")]
	[FieldOffset(Offset = "0x40")]
	public Transform BonusView;

	[Token(Token = "0x4015680")]
	[FieldOffset(Offset = "0x44")]
	public GameObject BonusReward;

	[Token(Token = "0x4015681")]
	[FieldOffset(Offset = "0x48")]
	public UILabel ladderExtraBonusRateTxt;

	[Token(Token = "0x4015682")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject ChampionshipBonusReward;

	[Token(Token = "0x4015683")]
	[FieldOffset(Offset = "0x50")]
	public UILabel ExpBonusLabel;

	[Token(Token = "0x4015684")]
	[FieldOffset(Offset = "0x54")]
	public UILabel GoldBonusLabel;

	[Token(Token = "0x4015685")]
	[FieldOffset(Offset = "0x58")]
	public UILabel BgameMode;

	[Token(Token = "0x4015686")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel BmapMode;

	[Token(Token = "0x4015687")]
	[FieldOffset(Offset = "0x60")]
	public GameObject DoublePointView;

	[Token(Token = "0x4015688")]
	[FieldOffset(Offset = "0x64")]
	public GameObject DoubleTokenView;

	[Token(Token = "0x4015689")]
	[FieldOffset(Offset = "0x68")]
	public GameObject NoDudectView;

	[Token(Token = "0x401568A")]
	[FieldOffset(Offset = "0x6C")]
	public UIButton mapBtn;

	[Token(Token = "0x401568B")]
	[FieldOffset(Offset = "0x70")]
	public GameObject ArrUp;

	[Token(Token = "0x401568C")]
	[FieldOffset(Offset = "0x74")]
	public GameObject ArrDown;

	[Token(Token = "0x401568D")]
	[FieldOffset(Offset = "0x78")]
	public GameObject mapSelectionBg;

	[Token(Token = "0x401568E")]
	[FieldOffset(Offset = "0x7C")]
	public Transform mapPopMenuContainer;

	[Token(Token = "0x401568F")]
	[FieldOffset(Offset = "0x80")]
	public UIWidget mapitem;

	[Token(Token = "0x4015690")]
	[FieldOffset(Offset = "0x84")]
	public UISprite Tag;

	[Token(Token = "0x601649A")]
	[Address(RVA = "0x217A1A4", Offset = "0x217A1A4", VA = "0x217A1A4")]
	public UIGameModeClassicInfoView()
	{
	}

	[Token(Token = "0x601649B")]
	[Address(RVA = "0x217A1AC", Offset = "0x217A1AC", VA = "0x217A1AC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601649C")]
	[Address(RVA = "0x217ACD8", Offset = "0x217ACD8", VA = "0x217ACD8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
