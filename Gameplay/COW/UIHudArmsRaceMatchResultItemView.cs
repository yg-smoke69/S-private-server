using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035D3")]
public class UIHudArmsRaceMatchResultItemView : UIBaseView
{
	[Token(Token = "0x40158BC")]
	[FieldOffset(Offset = "0x14")]
	public GameObject bg;

	[Token(Token = "0x40158BD")]
	[FieldOffset(Offset = "0x18")]
	public GameObject selfBg;

	[Token(Token = "0x40158BE")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject TopBG;

	[Token(Token = "0x40158BF")]
	[FieldOffset(Offset = "0x20")]
	public UIEffectSprite HeadIcon;

	[Token(Token = "0x40158C0")]
	[FieldOffset(Offset = "0x24")]
	public UILabel nickname;

	[Token(Token = "0x40158C1")]
	[FieldOffset(Offset = "0x28")]
	public UILabel clanName;

	[Token(Token = "0x40158C2")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Kill;

	[Token(Token = "0x40158C3")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Death;

	[Token(Token = "0x40158C4")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Assist;

	[Token(Token = "0x40158C5")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Damage;

	[Token(Token = "0x40158C6")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel Rank;

	[Token(Token = "0x40158C7")]
	[FieldOffset(Offset = "0x40")]
	public UIButton AddFriendBtn;

	[Token(Token = "0x6016527")]
	[Address(RVA = "0x17069E4", Offset = "0x17069E4", VA = "0x17069E4")]
	public UIHudArmsRaceMatchResultItemView()
	{
	}

	[Token(Token = "0x6016528")]
	[Address(RVA = "0x17069EC", Offset = "0x17069EC", VA = "0x17069EC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016529")]
	[Address(RVA = "0x1706F90", Offset = "0x1706F90", VA = "0x1706F90")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
