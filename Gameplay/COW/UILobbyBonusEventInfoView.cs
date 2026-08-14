using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200383A")]
public class UILobbyBonusEventInfoView : UIBaseView
{
	[Token(Token = "0x4016EFE")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid Grid;

	[Token(Token = "0x4016EFF")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ExpBonus;

	[Token(Token = "0x4016F00")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel ExpBonusValue;

	[Token(Token = "0x4016F01")]
	[FieldOffset(Offset = "0x20")]
	public UIButton GoldBonus;

	[Token(Token = "0x4016F02")]
	[FieldOffset(Offset = "0x24")]
	public UILabel GoldBonusValue;

	[Token(Token = "0x4016F03")]
	[FieldOffset(Offset = "0x28")]
	public UIButton GoldLimit;

	[Token(Token = "0x4016F04")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel GoldLimitValue;

	[Token(Token = "0x4016F05")]
	[FieldOffset(Offset = "0x30")]
	public UIButton DebrisLimit;

	[Token(Token = "0x4016F06")]
	[FieldOffset(Offset = "0x34")]
	public UILabel DebrisLimitValue;

	[Token(Token = "0x6016C59")]
	[Address(RVA = "0x216D37C", Offset = "0x216D37C", VA = "0x216D37C")]
	public UILobbyBonusEventInfoView()
	{
	}

	[Token(Token = "0x6016C5A")]
	[Address(RVA = "0x216D384", Offset = "0x216D384", VA = "0x216D384", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C5B")]
	[Address(RVA = "0x216D82C", Offset = "0x216D82C", VA = "0x216D82C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
