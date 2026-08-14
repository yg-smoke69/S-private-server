using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035D5")]
public class UIHudArmsRaceNextWeaponView : UIBaseView
{
	[Token(Token = "0x40158CC")]
	[FieldOffset(Offset = "0x14")]
	public GameObject InfoContainer;

	[Token(Token = "0x40158CD")]
	[FieldOffset(Offset = "0x18")]
	public GameObject arrow;

	[Token(Token = "0x40158CE")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite WeaponIcon;

	[Token(Token = "0x40158CF")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid NumGrid;

	[Token(Token = "0x40158D0")]
	[FieldOffset(Offset = "0x24")]
	public UISprite TenSprite;

	[Token(Token = "0x40158D1")]
	[FieldOffset(Offset = "0x28")]
	public UISprite UnitSprite;

	[Token(Token = "0x601652D")]
	[Address(RVA = "0x1707264", Offset = "0x1707264", VA = "0x1707264")]
	public UIHudArmsRaceNextWeaponView()
	{
	}

	[Token(Token = "0x601652E")]
	[Address(RVA = "0x170726C", Offset = "0x170726C", VA = "0x170726C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601652F")]
	[Address(RVA = "0x17075DC", Offset = "0x17075DC", VA = "0x17075DC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
