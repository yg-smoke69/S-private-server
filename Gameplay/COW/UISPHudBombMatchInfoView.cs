using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039B5")]
public class UISPHudBombMatchInfoView : UIBaseView
{
	[Token(Token = "0x40183BE")]
	[FieldOffset(Offset = "0x14")]
	public TweenPosition TweenPositionEconomyInfo;

	[Token(Token = "0x40183BF")]
	[FieldOffset(Offset = "0x18")]
	public TweenAlpha TweenAlphaEconomyInfo;

	[Token(Token = "0x40183C0")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject GameObjectEconomyInfo;

	[Token(Token = "0x40183C1")]
	[FieldOffset(Offset = "0x20")]
	public UILabel EconomyBlue;

	[Token(Token = "0x40183C2")]
	[FieldOffset(Offset = "0x24")]
	public UILabel EconomyRed;

	[Token(Token = "0x40183C3")]
	[FieldOffset(Offset = "0x28")]
	public UILabel TeamBlueName;

	[Token(Token = "0x40183C4")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel myWinNum;

	[Token(Token = "0x40183C5")]
	[FieldOffset(Offset = "0x30")]
	public UILabel oppoWinNum;

	[Token(Token = "0x40183C6")]
	[FieldOffset(Offset = "0x34")]
	public GameObject RoundInfo;

	[Token(Token = "0x40183C7")]
	[FieldOffset(Offset = "0x38")]
	public UILabel remainTime;

	[Token(Token = "0x40183C8")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel curRound;

	[Token(Token = "0x40183C9")]
	[FieldOffset(Offset = "0x40")]
	public GameObject BombCountdownInfo;

	[Token(Token = "0x40183CA")]
	[FieldOffset(Offset = "0x44")]
	public UISprite FillBg;

	[Token(Token = "0x40183CB")]
	[FieldOffset(Offset = "0x48")]
	public UILabel TeamRedName;

	[Token(Token = "0x40183CC")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite TeamBlueIcon;

	[Token(Token = "0x40183CD")]
	[FieldOffset(Offset = "0x50")]
	public UISprite TeamRedIcon;

	[Token(Token = "0x40183CE")]
	[FieldOffset(Offset = "0x54")]
	public GameObject TeamBlueDefaultIcon;

	[Token(Token = "0x40183CF")]
	[FieldOffset(Offset = "0x58")]
	public UISprite Team1Icon;

	[Token(Token = "0x40183D0")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject TeamRedDefaultIcon;

	[Token(Token = "0x40183D1")]
	[FieldOffset(Offset = "0x60")]
	public UISprite Team2Icon;

	[Token(Token = "0x40183D2")]
	[FieldOffset(Offset = "0x64")]
	public GameObject BombInfo;

	[Token(Token = "0x40183D3")]
	[FieldOffset(Offset = "0x68")]
	public UISprite BlueFactionIcon;

	[Token(Token = "0x40183D4")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite RedFactionIcon;

	[Token(Token = "0x40183D5")]
	[FieldOffset(Offset = "0x70")]
	public UIProgressBar BlueRemoveProgressBar;

	[Token(Token = "0x40183D6")]
	[FieldOffset(Offset = "0x74")]
	public UIProgressBar RedRemoveProgressBar;

	[Token(Token = "0x40183D7")]
	[FieldOffset(Offset = "0x78")]
	public GameObject BombIcon;

	[Token(Token = "0x40183D8")]
	[FieldOffset(Offset = "0x7C")]
	public UISprite BombLeftIcon;

	[Token(Token = "0x40183D9")]
	[FieldOffset(Offset = "0x80")]
	public GameObject VFX_BombLeftIcon;

	[Token(Token = "0x40183DA")]
	[FieldOffset(Offset = "0x84")]
	public UISprite BombRightIcon;

	[Token(Token = "0x40183DB")]
	[FieldOffset(Offset = "0x88")]
	public GameObject VFX_BombRightIcon;

	[Token(Token = "0x40183DC")]
	[FieldOffset(Offset = "0x8C")]
	public UIProgressBar BombLeftProgressBar;

	[Token(Token = "0x40183DD")]
	[FieldOffset(Offset = "0x90")]
	public UIProgressBar BombRightProgressBar;

	[Token(Token = "0x60170C6")]
	[Address(RVA = "0x1D0EFF4", Offset = "0x1D0EFF4", VA = "0x1D0EFF4")]
	public UISPHudBombMatchInfoView()
	{
	}

	[Token(Token = "0x60170C7")]
	[Address(RVA = "0x1D0EFFC", Offset = "0x1D0EFFC", VA = "0x1D0EFFC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170C8")]
	[Address(RVA = "0x1D0FCD8", Offset = "0x1D0FCD8", VA = "0x1D0FCD8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
