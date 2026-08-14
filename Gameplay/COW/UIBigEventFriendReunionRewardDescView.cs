using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033FA")]
public class UIBigEventFriendReunionRewardDescView : UIBaseView
{
	[Token(Token = "0x4014025")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIBigEventFriendReunionRewardDesc;

	[Token(Token = "0x4014026")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ExchangeEqual;

	[Token(Token = "0x4014027")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid ExchangeRewardGrid;

	[Token(Token = "0x4014028")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid ItemGrid;

	[Token(Token = "0x4014029")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnOperate;

	[Token(Token = "0x401402A")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BtnOperateBgYellow;

	[Token(Token = "0x401402B")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel BtnOperateLabel;

	[Token(Token = "0x401402C")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BtnOperateBgGray;

	[Token(Token = "0x401402D")]
	[FieldOffset(Offset = "0x34")]
	public UILabel BtnOperateLabelGray;

	[Token(Token = "0x401402E")]
	[FieldOffset(Offset = "0x38")]
	public GameObject BtnOperateBgWhite;

	[Token(Token = "0x401402F")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel BtnOperateLabelWhite;

	[Token(Token = "0x4014030")]
	[FieldOffset(Offset = "0x40")]
	public UILabel Progress;

	[Token(Token = "0x4014031")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Rewarded;

	[Token(Token = "0x4014032")]
	[FieldOffset(Offset = "0x48")]
	public UISprite ReunionInviterItemBg;

	[Token(Token = "0x6015FA2")]
	[Address(RVA = "0x3009E30", Offset = "0x3009E30", VA = "0x3009E30")]
	public UIBigEventFriendReunionRewardDescView()
	{
	}

	[Token(Token = "0x6015FA3")]
	[Address(RVA = "0x3009E38", Offset = "0x3009E38", VA = "0x3009E38", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FA4")]
	[Address(RVA = "0x300A484", Offset = "0x300A484", VA = "0x300A484")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
