using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003597")]
public class UIGachaShowRewardItemView : UIBaseView
{
	[Token(Token = "0x4015577")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIGachaShowRewardItem;

	[Token(Token = "0x4015578")]
	[FieldOffset(Offset = "0x18")]
	public GameObject GameObjectNormalContainer;

	[Token(Token = "0x4015579")]
	[FieldOffset(Offset = "0x1C")]
	public BaseItemView BaseItemViewNormalContainer;

	[Token(Token = "0x401557A")]
	[FieldOffset(Offset = "0x20")]
	public GameObject HighLightBG;

	[Token(Token = "0x401557B")]
	[FieldOffset(Offset = "0x24")]
	public GameObject timePanel;

	[Token(Token = "0x401557C")]
	[FieldOffset(Offset = "0x28")]
	public UILabel time;

	[Token(Token = "0x401557D")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject TokenTowerUniqueSprite;

	[Token(Token = "0x401557E")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Uniquedsprite;

	[Token(Token = "0x401557F")]
	[FieldOffset(Offset = "0x34")]
	public UISprite showicon;

	[Token(Token = "0x4015580")]
	[FieldOffset(Offset = "0x38")]
	public GameObject limittitle;

	[Token(Token = "0x4015581")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject SeniorVFX;

	[Token(Token = "0x4015582")]
	[FieldOffset(Offset = "0x40")]
	public GameObject JuniorVFX;

	[Token(Token = "0x4015583")]
	[FieldOffset(Offset = "0x44")]
	public UISprite SpritePurplePlus;

	[Token(Token = "0x4015584")]
	[FieldOffset(Offset = "0x48")]
	public UISprite Quality;

	[Token(Token = "0x4015585")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite Qualitybg;

	[Token(Token = "0x4015586")]
	[FieldOffset(Offset = "0x50")]
	public UISprite SpriteOrangePlus;

	[Token(Token = "0x4015587")]
	[FieldOffset(Offset = "0x54")]
	public UILabel DropUpLabel;

	[Token(Token = "0x4015588")]
	[FieldOffset(Offset = "0x58")]
	public GameObject RedVFX;

	[Token(Token = "0x6016475")]
	[Address(RVA = "0x2A2BF08", Offset = "0x2A2BF08", VA = "0x2A2BF08")]
	public UIGachaShowRewardItemView()
	{
	}

	[Token(Token = "0x6016476")]
	[Address(RVA = "0x2A2BF10", Offset = "0x2A2BF10", VA = "0x2A2BF10", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016477")]
	[Address(RVA = "0x2A2C6AC", Offset = "0x2A2C6AC", VA = "0x2A2C6AC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
