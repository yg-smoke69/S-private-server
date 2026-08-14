using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003691")]
public class UIHudLeaderboardItemView : UIBaseView
{
	[Token(Token = "0x4015F4B")]
	[FieldOffset(Offset = "0x14")]
	public AutoChangeComp m_AutoChangeComp;

	[Token(Token = "0x4015F4C")]
	[FieldOffset(Offset = "0x18")]
	public GameObject BGDefault;

	[Token(Token = "0x4015F4D")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject BGLocal;

	[Token(Token = "0x4015F4E")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelName;

	[Token(Token = "0x4015F4F")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelClan;

	[Token(Token = "0x4015F50")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelKill;

	[Token(Token = "0x4015F51")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel LabelDead;

	[Token(Token = "0x4015F52")]
	[FieldOffset(Offset = "0x30")]
	public UILabel LabelAssist;

	[Token(Token = "0x4015F53")]
	[FieldOffset(Offset = "0x34")]
	public UILabel LabelTotalDamage;

	[Token(Token = "0x4015F54")]
	[FieldOffset(Offset = "0x38")]
	public UISprite RankSprite;

	[Token(Token = "0x4015F55")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Icon_Celebrity;

	[Token(Token = "0x6016760")]
	[Address(RVA = "0xFEC238", Offset = "0xFEC238", VA = "0xFEC238")]
	public UIHudLeaderboardItemView()
	{
	}

	[Token(Token = "0x6016761")]
	[Address(RVA = "0xFEC240", Offset = "0xFEC240", VA = "0xFEC240", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016762")]
	[Address(RVA = "0xFEC784", Offset = "0xFEC784", VA = "0xFEC784")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
