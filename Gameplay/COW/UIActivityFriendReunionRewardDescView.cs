using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033A9")]
public class UIActivityFriendReunionRewardDescView : UIBaseView
{
	[Token(Token = "0x4013B9C")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIActivityFriendReunionRewardDesc;

	[Token(Token = "0x4013B9D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ExchangeEqual;

	[Token(Token = "0x4013B9E")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid ExchangeRewardGrid;

	[Token(Token = "0x4013B9F")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid ItemGrid;

	[Token(Token = "0x4013BA0")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnOperate;

	[Token(Token = "0x4013BA1")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BtnOperateBgYellow;

	[Token(Token = "0x4013BA2")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel BtnOperateLabel;

	[Token(Token = "0x4013BA3")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BtnOperateBgGray;

	[Token(Token = "0x4013BA4")]
	[FieldOffset(Offset = "0x34")]
	public UILabel BtnOperateLabelGray;

	[Token(Token = "0x4013BA5")]
	[FieldOffset(Offset = "0x38")]
	public GameObject BtnOperateBgWhite;

	[Token(Token = "0x4013BA6")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel BtnOperateLabelWhite;

	[Token(Token = "0x4013BA7")]
	[FieldOffset(Offset = "0x40")]
	public UILabel Progress;

	[Token(Token = "0x4013BA8")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Rewarded;

	[Token(Token = "0x4013BA9")]
	[FieldOffset(Offset = "0x48")]
	public UISprite ReunionInviterItemBg;

	[Token(Token = "0x6015EB1")]
	[Address(RVA = "0x2FB4724", Offset = "0x2FB4724", VA = "0x2FB4724")]
	public UIActivityFriendReunionRewardDescView()
	{
	}

	[Token(Token = "0x6015EB2")]
	[Address(RVA = "0x2FB472C", Offset = "0x2FB472C", VA = "0x2FB472C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EB3")]
	[Address(RVA = "0x2FB4D78", Offset = "0x2FB4D78", VA = "0x2FB4D78")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
