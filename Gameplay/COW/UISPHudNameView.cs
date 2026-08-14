using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039C5")]
public class UISPHudNameView : UIBaseView
{
	[Token(Token = "0x401848E")]
	[FieldOffset(Offset = "0x14")]
	public Animator UISPHudName;

	[Token(Token = "0x401848F")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget AlphaCtrlWidget;

	[Token(Token = "0x4018490")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Container;

	[Token(Token = "0x4018491")]
	[FieldOffset(Offset = "0x20")]
	public GameObject WeaponInfo;

	[Token(Token = "0x4018492")]
	[FieldOffset(Offset = "0x24")]
	public UISprite WeaponIcon;

	[Token(Token = "0x4018493")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Ammo;

	[Token(Token = "0x4018494")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel CurAmmo;

	[Token(Token = "0x4018495")]
	[FieldOffset(Offset = "0x30")]
	public UILabel MaxAmmo;

	[Token(Token = "0x4018496")]
	[FieldOffset(Offset = "0x34")]
	public GameObject InfiniteSprite;

	[Token(Token = "0x4018497")]
	[FieldOffset(Offset = "0x38")]
	public GameObject PlayerInfo;

	[Token(Token = "0x4018498")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject FlashIcon;

	[Token(Token = "0x4018499")]
	[FieldOffset(Offset = "0x40")]
	public UISprite HurtWave;

	[Token(Token = "0x401849A")]
	[FieldOffset(Offset = "0x44")]
	public UIButton QuickGoto;

	[Token(Token = "0x401849B")]
	[FieldOffset(Offset = "0x48")]
	public UILabel TeamId;

	[Token(Token = "0x401849C")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite TeamBg;

	[Token(Token = "0x401849D")]
	[FieldOffset(Offset = "0x50")]
	public UISprite TeamBorder;

	[Token(Token = "0x401849E")]
	[FieldOffset(Offset = "0x54")]
	public UIWidget TeamIconGo;

	[Token(Token = "0x401849F")]
	[FieldOffset(Offset = "0x58")]
	public UIEffectSprite TeamIcon;

	[Token(Token = "0x40184A0")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite TeamFakeIcon;

	[Token(Token = "0x40184A1")]
	[FieldOffset(Offset = "0x60")]
	public UISprite TeamIconBG;

	[Token(Token = "0x40184A2")]
	[FieldOffset(Offset = "0x64")]
	public UILabel Name;

	[Token(Token = "0x40184A3")]
	[FieldOffset(Offset = "0x68")]
	public UISprite Knockdown;

	[Token(Token = "0x40184A4")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject Hp;

	[Token(Token = "0x40184A5")]
	[FieldOffset(Offset = "0x70")]
	public UISprite Hpbarfg;

	[Token(Token = "0x40184A6")]
	[FieldOffset(Offset = "0x74")]
	public UISprite Hpbarbg;

	[Token(Token = "0x40184A7")]
	[FieldOffset(Offset = "0x78")]
	public GameObject TeamMateIcon;

	[Token(Token = "0x40184A8")]
	[FieldOffset(Offset = "0x7C")]
	public UISprite Bg;

	[Token(Token = "0x40184A9")]
	[FieldOffset(Offset = "0x80")]
	public UIWidget KokGo;

	[Token(Token = "0x40184AA")]
	[FieldOffset(Offset = "0x84")]
	public UIEffectWidget KokVFX;

	[Token(Token = "0x40184AB")]
	[FieldOffset(Offset = "0x88")]
	public GameObject KokPlayerGO;

	[Token(Token = "0x40184AC")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject MiniContainer;

	[Token(Token = "0x40184AD")]
	[FieldOffset(Offset = "0x90")]
	public GameObject MiniPlayerInfo;

	[Token(Token = "0x40184AE")]
	[FieldOffset(Offset = "0x94")]
	public UIButton MiniQuickGoto;

	[Token(Token = "0x40184AF")]
	[FieldOffset(Offset = "0x98")]
	public UILabel MiniTeamId;

	[Token(Token = "0x40184B0")]
	[FieldOffset(Offset = "0x9C")]
	public UISprite MiniTeamBg;

	[Token(Token = "0x40184B1")]
	[FieldOffset(Offset = "0xA0")]
	public UISprite MiniTeamBorder;

	[Token(Token = "0x40184B2")]
	[FieldOffset(Offset = "0xA4")]
	public UIWidget MiniTeamIconGo;

	[Token(Token = "0x40184B3")]
	[FieldOffset(Offset = "0xA8")]
	public UIEffectSprite MiniTeamIcon;

	[Token(Token = "0x40184B4")]
	[FieldOffset(Offset = "0xAC")]
	public UISprite MiniTeamFakeIcon;

	[Token(Token = "0x40184B5")]
	[FieldOffset(Offset = "0xB0")]
	public UIWidget KokMinGo;

	[Token(Token = "0x40184B6")]
	[FieldOffset(Offset = "0xB4")]
	public UIEffectWidget MiniKokVFX;

	[Token(Token = "0x40184B7")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject KokPlayerMinGO;

	[Token(Token = "0x40184B8")]
	[FieldOffset(Offset = "0xBC")]
	public UISprite BombIcon;

	[Token(Token = "0x60170F6")]
	[Address(RVA = "0x1D23180", Offset = "0x1D23180", VA = "0x1D23180")]
	public UISPHudNameView()
	{
	}

	[Token(Token = "0x60170F7")]
	[Address(RVA = "0x1D23188", Offset = "0x1D23188", VA = "0x1D23188", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170F8")]
	[Address(RVA = "0x1D24260", Offset = "0x1D24260", VA = "0x1D24260")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
