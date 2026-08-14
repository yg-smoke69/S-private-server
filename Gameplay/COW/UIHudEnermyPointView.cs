using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003644")]
public class UIHudEnermyPointView : UIBaseView
{
	[Token(Token = "0x4015C4E")]
	[FieldOffset(Offset = "0x14")]
	public GameObject EnermyHint;

	[Token(Token = "0x4015C4F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject BanSkillMark;

	[Token(Token = "0x4015C50")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject DeliveryMark;

	[Token(Token = "0x4015C51")]
	[FieldOffset(Offset = "0x20")]
	public GameObject CuringEnemyMark;

	[Token(Token = "0x4015C52")]
	[FieldOffset(Offset = "0x24")]
	public GameObject IceWallNearbyEnemyMark;

	[Token(Token = "0x6016679")]
	[Address(RVA = "0x1CE5CD8", Offset = "0x1CE5CD8", VA = "0x1CE5CD8")]
	public UIHudEnermyPointView()
	{
	}

	[Token(Token = "0x601667A")]
	[Address(RVA = "0x1CE5CE0", Offset = "0x1CE5CE0", VA = "0x1CE5CE0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601667B")]
	[Address(RVA = "0x1CE5FCC", Offset = "0x1CE5FCC", VA = "0x1CE5FCC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
