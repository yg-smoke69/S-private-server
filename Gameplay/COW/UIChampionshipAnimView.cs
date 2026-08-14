using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003409")]
public class UIChampionshipAnimView : UIBaseView
{
	[Token(Token = "0x401412D")]
	[FieldOffset(Offset = "0x14")]
	public Animator Animator;

	[Token(Token = "0x401412E")]
	[FieldOffset(Offset = "0x18")]
	public UILabel SeasonID;

	[Token(Token = "0x401412F")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel SeasonName;

	[Token(Token = "0x4014130")]
	[FieldOffset(Offset = "0x20")]
	public UILabel SeasonTime;

	[Token(Token = "0x4014131")]
	[FieldOffset(Offset = "0x24")]
	public GameObject SeasonInfo;

	[Token(Token = "0x4014132")]
	[FieldOffset(Offset = "0x28")]
	public GameObject DefaultIcon;

	[Token(Token = "0x4014133")]
	[FieldOffset(Offset = "0x2C")]
	public UINetworkTexture CDNIcon;

	[Token(Token = "0x4014134")]
	[FieldOffset(Offset = "0x30")]
	public GameObject ExclusiveAwardEffect;

	[Token(Token = "0x4014135")]
	[FieldOffset(Offset = "0x34")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x4014136")]
	[FieldOffset(Offset = "0x38")]
	public UIButton GotoMailBtn;

	[Token(Token = "0x4014137")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ResultInfo;

	[Token(Token = "0x4014138")]
	[FieldOffset(Offset = "0x40")]
	public UILabel RankScore;

	[Token(Token = "0x4014139")]
	[FieldOffset(Offset = "0x44")]
	public UISprite CupIcon;

	[Token(Token = "0x401413A")]
	[FieldOffset(Offset = "0x48")]
	public UILabel RankPos;

	[Token(Token = "0x401413B")]
	[FieldOffset(Offset = "0x4C")]
	public UIGrid RewardList;

	[Token(Token = "0x401413C")]
	[FieldOffset(Offset = "0x50")]
	public GameObject Map;

	[Token(Token = "0x6015FCF")]
	[Address(RVA = "0x145CBBC", Offset = "0x145CBBC", VA = "0x145CBBC")]
	public UIChampionshipAnimView()
	{
	}

	[Token(Token = "0x6015FD0")]
	[Address(RVA = "0x145CBC4", Offset = "0x145CBC4", VA = "0x145CBC4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FD1")]
	[Address(RVA = "0x145D2D0", Offset = "0x145D2D0", VA = "0x145D2D0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
