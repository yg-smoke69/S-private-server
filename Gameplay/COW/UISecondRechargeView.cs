using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039A8")]
public class UISecondRechargeView : UIBaseView
{
	[Token(Token = "0x4018336")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnClose;

	[Token(Token = "0x4018337")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture Tex;

	[Token(Token = "0x4018338")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject HideBeforeCDNLoaded;

	[Token(Token = "0x4018339")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnGoToRecharge;

	[Token(Token = "0x401833A")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnClaim;

	[Token(Token = "0x401833B")]
	[FieldOffset(Offset = "0x28")]
	public UILabel BtnClaimLabel;

	[Token(Token = "0x401833C")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel BtnClaimLabelGray;

	[Token(Token = "0x401833D")]
	[FieldOffset(Offset = "0x30")]
	public UIGrid Grid;

	[Token(Token = "0x401833E")]
	[FieldOffset(Offset = "0x34")]
	public GameObject BeforeTopUp;

	[Token(Token = "0x401833F")]
	[FieldOffset(Offset = "0x38")]
	public UINetworkTexture CDN_FREE;

	[Token(Token = "0x4018340")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject AfterTopUp;

	[Token(Token = "0x4018341")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Label_choose_tips;

	[Token(Token = "0x4018342")]
	[FieldOffset(Offset = "0x44")]
	public GameObject BtnItemGray;

	[Token(Token = "0x4018343")]
	[FieldOffset(Offset = "0x48")]
	public GameObject Vfx;

	[Token(Token = "0x4018344")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject A;

	[Token(Token = "0x4018345")]
	[FieldOffset(Offset = "0x50")]
	public GameObject A1;

	[Token(Token = "0x4018346")]
	[FieldOffset(Offset = "0x54")]
	public GameObject A2;

	[Token(Token = "0x4018347")]
	[FieldOffset(Offset = "0x58")]
	public GameObject A3;

	[Token(Token = "0x4018348")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject B;

	[Token(Token = "0x4018349")]
	[FieldOffset(Offset = "0x60")]
	public GameObject B1;

	[Token(Token = "0x401834A")]
	[FieldOffset(Offset = "0x64")]
	public GameObject B2;

	[Token(Token = "0x401834B")]
	[FieldOffset(Offset = "0x68")]
	public GameObject B3;

	[Token(Token = "0x601709F")]
	[Address(RVA = "0x1A50C40", Offset = "0x1A50C40", VA = "0x1A50C40")]
	public UISecondRechargeView()
	{
	}

	[Token(Token = "0x60170A0")]
	[Address(RVA = "0x1A50C48", Offset = "0x1A50C48", VA = "0x1A50C48", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170A1")]
	[Address(RVA = "0x1A51528", Offset = "0x1A51528", VA = "0x1A51528")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
