using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035A3")]
public class UIGameModeCasualInfoView : UIBaseView
{
	[Token(Token = "0x401565D")]
	[FieldOffset(Offset = "0x14")]
	public GameObject gray;

	[Token(Token = "0x401565E")]
	[FieldOffset(Offset = "0x18")]
	public UILabel matchMode;

	[Token(Token = "0x401565F")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject MapModeTipsAnim;

	[Token(Token = "0x4015660")]
	[FieldOffset(Offset = "0x20")]
	public UILabel tips;

	[Token(Token = "0x4015661")]
	[FieldOffset(Offset = "0x24")]
	public Transform NormalView;

	[Token(Token = "0x4015662")]
	[FieldOffset(Offset = "0x28")]
	public UILabel gameMode;

	[Token(Token = "0x4015663")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel mapMode;

	[Token(Token = "0x4015664")]
	[FieldOffset(Offset = "0x30")]
	public UIButton SwitchMapModeBtn;

	[Token(Token = "0x4015665")]
	[FieldOffset(Offset = "0x34")]
	public Transform BonusView;

	[Token(Token = "0x4015666")]
	[FieldOffset(Offset = "0x38")]
	public GameObject BonusReward;

	[Token(Token = "0x4015667")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel ladderExtraBonusRateTxt;

	[Token(Token = "0x4015668")]
	[FieldOffset(Offset = "0x40")]
	public GameObject ChampionshipBonusReward;

	[Token(Token = "0x4015669")]
	[FieldOffset(Offset = "0x44")]
	public UILabel ExpBonusLabel;

	[Token(Token = "0x401566A")]
	[FieldOffset(Offset = "0x48")]
	public UILabel GoldBonusLabel;

	[Token(Token = "0x401566B")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel BgameMode;

	[Token(Token = "0x401566C")]
	[FieldOffset(Offset = "0x50")]
	public UILabel BmapMode;

	[Token(Token = "0x401566D")]
	[FieldOffset(Offset = "0x54")]
	public UILabel specialClassicMapMode;

	[Token(Token = "0x401566E")]
	[FieldOffset(Offset = "0x58")]
	public GameObject DoublePointView;

	[Token(Token = "0x401566F")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject DoubleTokenView;

	[Token(Token = "0x4015670")]
	[FieldOffset(Offset = "0x60")]
	public GameObject NoDudectView;

	[Token(Token = "0x4015671")]
	[FieldOffset(Offset = "0x64")]
	public Transform mapPopMenuContainer;

	[Token(Token = "0x4015672")]
	[FieldOffset(Offset = "0x68")]
	public UIWidget mapitem;

	[Token(Token = "0x4015673")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite Tag;

	[Token(Token = "0x6016497")]
	[Address(RVA = "0x2176804", Offset = "0x2176804", VA = "0x2176804")]
	public UIGameModeCasualInfoView()
	{
	}

	[Token(Token = "0x6016498")]
	[Address(RVA = "0x217680C", Offset = "0x217680C", VA = "0x217680C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016499")]
	[Address(RVA = "0x2177128", Offset = "0x2177128", VA = "0x2177128")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
