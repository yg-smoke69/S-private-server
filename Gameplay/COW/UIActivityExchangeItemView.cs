using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033A5")]
public class UIActivityExchangeItemView : UIBaseView
{
	[Token(Token = "0x4013B71")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIActivityExchangeItem;

	[Token(Token = "0x4013B72")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView AwardScrollView;

	[Token(Token = "0x4013B73")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid AwardGrid;

	[Token(Token = "0x4013B74")]
	[FieldOffset(Offset = "0x20")]
	public Transform ExchangeItemGrid;

	[Token(Token = "0x4013B75")]
	[FieldOffset(Offset = "0x24")]
	public UIButton Operation;

	[Token(Token = "0x4013B76")]
	[FieldOffset(Offset = "0x28")]
	public Animation ButtonAnimation;

	[Token(Token = "0x4013B77")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject BGGray;

	[Token(Token = "0x4013B78")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BGYellow;

	[Token(Token = "0x4013B79")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Gained;

	[Token(Token = "0x4013B7A")]
	[FieldOffset(Offset = "0x38")]
	public UILabel GainedLabel;

	[Token(Token = "0x4013B7B")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel Title;

	[Token(Token = "0x4013B7C")]
	[FieldOffset(Offset = "0x40")]
	public UIToggle RedTipsOnOff;

	[Token(Token = "0x4013B7D")]
	[FieldOffset(Offset = "0x44")]
	public GameObject ProgressIcon;

	[Token(Token = "0x4013B7E")]
	[FieldOffset(Offset = "0x48")]
	public UILabel ProgressTips;

	[Token(Token = "0x6015EA5")]
	[Address(RVA = "0x2FA90E4", Offset = "0x2FA90E4", VA = "0x2FA90E4")]
	public UIActivityExchangeItemView()
	{
	}

	[Token(Token = "0x6015EA6")]
	[Address(RVA = "0x2FA90EC", Offset = "0x2FA90EC", VA = "0x2FA90EC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EA7")]
	[Address(RVA = "0x2FA971C", Offset = "0x2FA971C", VA = "0x2FA971C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
