using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002289")]
public class UISPHudCSTeammateInfoDetailView : MonoBehaviour
{
	[Token(Token = "0x400D834")]
	[FieldOffset(Offset = "0xC")]
	public GameObject HP;

	[Token(Token = "0x400D835")]
	[FieldOffset(Offset = "0x10")]
	public UISprite Hpbarfg;

	[Token(Token = "0x400D836")]
	[FieldOffset(Offset = "0x14")]
	public UILabel NameTxt;

	[Token(Token = "0x400D837")]
	[FieldOffset(Offset = "0x18")]
	public TweenPosition TWNamePosition;

	[Token(Token = "0x400D838")]
	[FieldOffset(Offset = "0x1C")]
	public TweenAlpha TWNameAlpha;

	[Token(Token = "0x400D839")]
	[FieldOffset(Offset = "0x20")]
	public UISprite HelmetBG;

	[Token(Token = "0x400D83A")]
	[FieldOffset(Offset = "0x24")]
	public UISprite FilledHelmet;

	[Token(Token = "0x400D83B")]
	[FieldOffset(Offset = "0x28")]
	public UISprite FilledHelmetEnhanced;

	[Token(Token = "0x400D83C")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite HelmetLevel;

	[Token(Token = "0x400D83D")]
	[FieldOffset(Offset = "0x30")]
	public UISprite ArmorBG;

	[Token(Token = "0x400D83E")]
	[FieldOffset(Offset = "0x34")]
	public UISprite FilledArmor;

	[Token(Token = "0x400D83F")]
	[FieldOffset(Offset = "0x38")]
	public UISprite FilledArmorEnhanced;

	[Token(Token = "0x400D840")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite ArmorLevel;

	[Token(Token = "0x400D841")]
	[FieldOffset(Offset = "0x40")]
	public TweenAlpha TWMoneyAlpha;

	[Token(Token = "0x400D842")]
	[FieldOffset(Offset = "0x44")]
	public UISprite WeaponIconMain1;

	[Token(Token = "0x400D843")]
	[FieldOffset(Offset = "0x48")]
	public TweenAlpha WeaponTween1;

	[Token(Token = "0x400D844")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject FireEffectGo1;

	[Token(Token = "0x400D845")]
	[FieldOffset(Offset = "0x50")]
	public UISprite WeaponIconMain2;

	[Token(Token = "0x400D846")]
	[FieldOffset(Offset = "0x54")]
	public TweenAlpha WeaponTween2;

	[Token(Token = "0x400D847")]
	[FieldOffset(Offset = "0x58")]
	public GameObject FireEffectGo2;

	[Token(Token = "0x400D848")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject SelectBG;

	[Token(Token = "0x400D849")]
	[FieldOffset(Offset = "0x60")]
	public GameObject BombIcon;

	[Token(Token = "0x400D84A")]
	[FieldOffset(Offset = "0x64")]
	public GameObject PliersIcon;

	[Token(Token = "0x400D84B")]
	[FieldOffset(Offset = "0x68")]
	private int curHelmetLevel;

	[Token(Token = "0x400D84C")]
	[FieldOffset(Offset = "0x6C")]
	private int curArmorLevel;

	[Token(Token = "0x400D84D")]
	[FieldOffset(Offset = "0x70")]
	private string FilledArmorIcon;

	[Token(Token = "0x400D84E")]
	[FieldOffset(Offset = "0x74")]
	private string FilledArmorIconBG;

	[Token(Token = "0x400D84F")]
	[FieldOffset(Offset = "0x78")]
	private string FilledArmorIconExplode;

	[Token(Token = "0x400D850")]
	[FieldOffset(Offset = "0x7C")]
	private string FilledArmorIconExplodeBG;

	[Token(Token = "0x400D851")]
	[FieldOffset(Offset = "0x80")]
	private string FilledHeadIcon;

	[Token(Token = "0x400D852")]
	[FieldOffset(Offset = "0x84")]
	private string FilledHeadIconBG;

	[Token(Token = "0x400D853")]
	[FieldOffset(Offset = "0x88")]
	private string FilledHeadIconProtect;

	[Token(Token = "0x400D854")]
	[FieldOffset(Offset = "0x8C")]
	private string FilledHeadIconProtectBG;

	[Token(Token = "0x600BD65")]
	[Address(RVA = "0x1D18DF0", Offset = "0x1D18DF0", VA = "0x1D18DF0")]
	public UISPHudCSTeammateInfoDetailView()
	{
	}

	[Token(Token = "0x600BD66")]
	[Address(RVA = "0x1D18EF4", Offset = "0x1D18EF4", VA = "0x1D18EF4")]
	public void UpdateHelmetStats(IHAAMHPPLMG playerID)
	{
	}

	[Token(Token = "0x600BD67")]
	[Address(RVA = "0x1D1963C", Offset = "0x1D1963C", VA = "0x1D1963C")]
	public void UpdateArmorStats(IHAAMHPPLMG playerID)
	{
	}

	[Token(Token = "0x600BD68")]
	[Address(RVA = "0x1D194C0", Offset = "0x1D194C0", VA = "0x1D194C0")]
	public void ClearHelmetState()
	{
	}

	[Token(Token = "0x600BD69")]
	[Address(RVA = "0x1D19BE8", Offset = "0x1D19BE8", VA = "0x1D19BE8")]
	public void ClearArmorStats()
	{
	}
}
