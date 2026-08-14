using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003501")]
public class UIElitePassDiscountView : UIBaseView
{
	[Token(Token = "0x4014E12")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UIElitePassDiscount;

	[Token(Token = "0x4014E13")]
	[FieldOffset(Offset = "0x18")]
	public UILabel BonusFinalResultLabel;

	[Token(Token = "0x4014E14")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject BonusTipsContainer;

	[Token(Token = "0x4014E15")]
	[FieldOffset(Offset = "0x20")]
	public UILabel BonusTipsLabel;

	[Token(Token = "0x4014E16")]
	[FieldOffset(Offset = "0x24")]
	public GameObject BonusSpinUnFinishedVFX;

	[Token(Token = "0x4014E17")]
	[FieldOffset(Offset = "0x28")]
	public MeshRenderer number_ones;

	[Token(Token = "0x4014E18")]
	[FieldOffset(Offset = "0x2C")]
	public MeshRenderer number_tens;

	[Token(Token = "0x4014E19")]
	[FieldOffset(Offset = "0x30")]
	public MeshRenderer number_hunderds;

	[Token(Token = "0x4014E1A")]
	[FieldOffset(Offset = "0x34")]
	public UIButton GetBonusBtn;

	[Token(Token = "0x4014E1B")]
	[FieldOffset(Offset = "0x38")]
	public UILabel BonusCongratulationLabel;

	[Token(Token = "0x4014E1C")]
	[FieldOffset(Offset = "0x3C")]
	public UINetworkTexture AvatarCDN;

	[Token(Token = "0x4014E1D")]
	[FieldOffset(Offset = "0x40")]
	public UILabel GetBonusStartLabel;

	[Token(Token = "0x4014E1E")]
	[FieldOffset(Offset = "0x44")]
	public Animation BonusAnimation;

	[Token(Token = "0x4014E1F")]
	[FieldOffset(Offset = "0x48")]
	public GameObject timebg;

	[Token(Token = "0x60162B3")]
	[Address(RVA = "0x2A54CC0", Offset = "0x2A54CC0", VA = "0x2A54CC0")]
	public UIElitePassDiscountView()
	{
	}

	[Token(Token = "0x60162B4")]
	[Address(RVA = "0x2A54CC8", Offset = "0x2A54CC8", VA = "0x2A54CC8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162B5")]
	[Address(RVA = "0x2A55320", Offset = "0x2A55320", VA = "0x2A55320")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
