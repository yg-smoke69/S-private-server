using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A53")]
public class UIVeteranBundleView : UIBaseView
{
	[Token(Token = "0x4018A97")]
	[FieldOffset(Offset = "0x14")]
	public GameObject BundleImageLocal;

	[Token(Token = "0x4018A98")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTextureExt BundleImageRemote;

	[Token(Token = "0x4018A99")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4018A9A")]
	[FieldOffset(Offset = "0x20")]
	public UIEasyList List;

	[Token(Token = "0x4018A9B")]
	[FieldOffset(Offset = "0x24")]
	public GameObject WaitClaim;

	[Token(Token = "0x4018A9C")]
	[FieldOffset(Offset = "0x28")]
	public UIButton Operation;

	[Token(Token = "0x4018A9D")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel ActualPriceLabel;

	[Token(Token = "0x4018A9E")]
	[FieldOffset(Offset = "0x30")]
	public UILabel OriginalPriceLabel;

	[Token(Token = "0x4018A9F")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Claimed;

	[Token(Token = "0x4018AA0")]
	[FieldOffset(Offset = "0x38")]
	public UISprite GreySprite;

	[Token(Token = "0x4018AA1")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel ClaimedLabel;

	[Token(Token = "0x601729F")]
	[Address(RVA = "0x28455D0", Offset = "0x28455D0", VA = "0x28455D0")]
	public UIVeteranBundleView()
	{
	}

	[Token(Token = "0x60172A0")]
	[Address(RVA = "0x28455D8", Offset = "0x28455D8", VA = "0x28455D8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172A1")]
	[Address(RVA = "0x28459FC", Offset = "0x28459FC", VA = "0x28459FC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
