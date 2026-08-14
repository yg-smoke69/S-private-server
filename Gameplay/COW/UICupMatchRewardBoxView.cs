using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200349F")]
public class UICupMatchRewardBoxView : UIBaseView
{
	[Token(Token = "0x4014892")]
	[FieldOffset(Offset = "0x14")]
	public UIButton RewardBtn;

	[Token(Token = "0x4014893")]
	[FieldOffset(Offset = "0x18")]
	public UISprite RewardIcon;

	[Token(Token = "0x4014894")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject VFX_Box04;

	[Token(Token = "0x4014895")]
	[FieldOffset(Offset = "0x20")]
	public GameObject VFX_Box03;

	[Token(Token = "0x4014896")]
	[FieldOffset(Offset = "0x24")]
	public GameObject VFX_Box02;

	[Token(Token = "0x4014897")]
	[FieldOffset(Offset = "0x28")]
	public GameObject VFX_Box01;

	[Token(Token = "0x4014898")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject VFX_Up;

	[Token(Token = "0x4014899")]
	[FieldOffset(Offset = "0x30")]
	public UILabel RewardName;

	[Token(Token = "0x401489A")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Claimed;

	[Token(Token = "0x401489B")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Result;

	[Token(Token = "0x401489C")]
	[FieldOffset(Offset = "0x3C")]
	public Transform Result1;

	[Token(Token = "0x401489D")]
	[FieldOffset(Offset = "0x40")]
	public Transform Result2;

	[Token(Token = "0x401489E")]
	[FieldOffset(Offset = "0x44")]
	public Transform Result3;

	[Token(Token = "0x401489F")]
	[FieldOffset(Offset = "0x48")]
	public CupMatchRewardBoxResultItem ResultTemplate;

	[Token(Token = "0x40148A0")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject RedPoint;

	[Token(Token = "0x40148A1")]
	[FieldOffset(Offset = "0x50")]
	public Transform ResultTopPos;

	[Token(Token = "0x6016191")]
	[Address(RVA = "0x2AB3E7C", Offset = "0x2AB3E7C", VA = "0x2AB3E7C")]
	public UICupMatchRewardBoxView()
	{
	}

	[Token(Token = "0x6016192")]
	[Address(RVA = "0x2AB3E84", Offset = "0x2AB3E84", VA = "0x2AB3E84", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016193")]
	[Address(RVA = "0x2AB44CC", Offset = "0x2AB44CC", VA = "0x2AB44CC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
