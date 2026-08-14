using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039BB")]
public class UISPHudCSMatchInfoView : UIBaseView
{
	[Token(Token = "0x40183ED")]
	[FieldOffset(Offset = "0x14")]
	public TweenPosition TWPosition;

	[Token(Token = "0x40183EE")]
	[FieldOffset(Offset = "0x18")]
	public TweenAlpha TWAlpha;

	[Token(Token = "0x40183EF")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject EconomyInfo;

	[Token(Token = "0x40183F0")]
	[FieldOffset(Offset = "0x20")]
	public UILabel EconomyBlue;

	[Token(Token = "0x40183F1")]
	[FieldOffset(Offset = "0x24")]
	public UILabel EconomyRed;

	[Token(Token = "0x40183F2")]
	[FieldOffset(Offset = "0x28")]
	public UIProgressBar EconomyBar;

	[Token(Token = "0x40183F3")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel TeamBlueName;

	[Token(Token = "0x40183F4")]
	[FieldOffset(Offset = "0x30")]
	public UILabel myWinNum;

	[Token(Token = "0x40183F5")]
	[FieldOffset(Offset = "0x34")]
	public UILabel oppoWinNum;

	[Token(Token = "0x40183F6")]
	[FieldOffset(Offset = "0x38")]
	public GameObject RoundInfo;

	[Token(Token = "0x40183F7")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel remainTime;

	[Token(Token = "0x40183F8")]
	[FieldOffset(Offset = "0x40")]
	public UILabel curRound;

	[Token(Token = "0x40183F9")]
	[FieldOffset(Offset = "0x44")]
	public GameObject BombCountdownInfo;

	[Token(Token = "0x40183FA")]
	[FieldOffset(Offset = "0x48")]
	public UISprite FillBg;

	[Token(Token = "0x40183FB")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel TeamRedName;

	[Token(Token = "0x40183FC")]
	[FieldOffset(Offset = "0x50")]
	public UISprite TeamBlueIcon;

	[Token(Token = "0x40183FD")]
	[FieldOffset(Offset = "0x54")]
	public UISprite TeamRedIcon;

	[Token(Token = "0x40183FE")]
	[FieldOffset(Offset = "0x58")]
	public GameObject TeamBlueDefaultIcon;

	[Token(Token = "0x40183FF")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite Team1Icon;

	[Token(Token = "0x4018400")]
	[FieldOffset(Offset = "0x60")]
	public GameObject TeamRedDefaultIcon;

	[Token(Token = "0x4018401")]
	[FieldOffset(Offset = "0x64")]
	public UISprite Team2Icon;

	[Token(Token = "0x4018402")]
	[FieldOffset(Offset = "0x68")]
	public GameObject BombInfo;

	[Token(Token = "0x4018403")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite BlueFactionIcon;

	[Token(Token = "0x4018404")]
	[FieldOffset(Offset = "0x70")]
	public UISprite RedFactionIcon;

	[Token(Token = "0x4018405")]
	[FieldOffset(Offset = "0x74")]
	public UIProgressBar BlueRemoveProgressBar;

	[Token(Token = "0x4018406")]
	[FieldOffset(Offset = "0x78")]
	public UILabel BlueRemoveHint;

	[Token(Token = "0x4018407")]
	[FieldOffset(Offset = "0x7C")]
	public UIProgressBar RedRemoveProgressBar;

	[Token(Token = "0x4018408")]
	[FieldOffset(Offset = "0x80")]
	public UILabel RedRemoveHint;

	[Token(Token = "0x60170D8")]
	[Address(RVA = "0x1D14D20", Offset = "0x1D14D20", VA = "0x1D14D20")]
	public UISPHudCSMatchInfoView()
	{
	}

	[Token(Token = "0x60170D9")]
	[Address(RVA = "0x1D14D28", Offset = "0x1D14D28", VA = "0x1D14D28", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170DA")]
	[Address(RVA = "0x1D156B0", Offset = "0x1D156B0", VA = "0x1D156B0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
