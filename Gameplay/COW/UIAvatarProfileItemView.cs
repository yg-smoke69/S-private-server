using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033D2")]
public class UIAvatarProfileItemView : UIBaseView
{
	[Token(Token = "0x4013D82")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ProfileBtn;

	[Token(Token = "0x4013D83")]
	[FieldOffset(Offset = "0x18")]
	public GameObject UnlockNode;

	[Token(Token = "0x4013D84")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel ProfileTitle;

	[Token(Token = "0x4013D85")]
	[FieldOffset(Offset = "0x20")]
	public GameObject LockNode;

	[Token(Token = "0x4013D86")]
	[FieldOffset(Offset = "0x24")]
	public UILabel TXT_PROFILE_LOCKED_INVISIBLE;

	[Token(Token = "0x4013D87")]
	[FieldOffset(Offset = "0x28")]
	public GameObject CanUnlockNode;

	[Token(Token = "0x4013D88")]
	[FieldOffset(Offset = "0x2C")]
	public Transform unlockTips;

	[Token(Token = "0x4013D89")]
	[FieldOffset(Offset = "0x30")]
	public GameObject TipsGO;

	[Token(Token = "0x4013D8A")]
	[FieldOffset(Offset = "0x34")]
	public GameObject SatisfyHL;

	[Token(Token = "0x4013D8B")]
	[FieldOffset(Offset = "0x38")]
	public GameObject HasOwnObject;

	[Token(Token = "0x4013D8C")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel NeedLevel;

	[Token(Token = "0x4013D8D")]
	[FieldOffset(Offset = "0x40")]
	public UILabel DebrisCount;

	[Token(Token = "0x4013D8E")]
	[FieldOffset(Offset = "0x44")]
	public GameObject NotOwnObject;

	[Token(Token = "0x4013D8F")]
	[FieldOffset(Offset = "0x48")]
	public UIButton AwardBtn;

	[Token(Token = "0x4013D90")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite AwardSprite;

	[Token(Token = "0x4013D91")]
	[FieldOffset(Offset = "0x50")]
	public UISprite UnKnownAward;

	[Token(Token = "0x6015F2C")]
	[Address(RVA = "0x2B74168", Offset = "0x2B74168", VA = "0x2B74168")]
	public UIAvatarProfileItemView()
	{
	}

	[Token(Token = "0x6015F2D")]
	[Address(RVA = "0x2B74170", Offset = "0x2B74170", VA = "0x2B74170", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F2E")]
	[Address(RVA = "0x2B7483C", Offset = "0x2B7483C", VA = "0x2B7483C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
