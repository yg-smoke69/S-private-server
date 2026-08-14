using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003939")]
public class UIPVEWeaponPropertyView : UIBaseView
{
	[Token(Token = "0x4017F16")]
	[FieldOffset(Offset = "0x14")]
	public GameObject propertyScore;

	[Token(Token = "0x4017F17")]
	[FieldOffset(Offset = "0x18")]
	public UISprite bg;

	[Token(Token = "0x4017F18")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid scoreGrid;

	[Token(Token = "0x4017F19")]
	[FieldOffset(Offset = "0x20")]
	public UIPVEWeaponPropertyItemView item;

	[Token(Token = "0x4017F1A")]
	[FieldOffset(Offset = "0x24")]
	public UILabel desc;

	[Token(Token = "0x4017F1B")]
	[FieldOffset(Offset = "0x28")]
	public UILabel pValue;

	[Token(Token = "0x6016F52")]
	[Address(RVA = "0x15ADDAC", Offset = "0x15ADDAC", VA = "0x15ADDAC")]
	public UIPVEWeaponPropertyView()
	{
	}

	[Token(Token = "0x6016F53")]
	[Address(RVA = "0x15ADDB4", Offset = "0x15ADDB4", VA = "0x15ADDB4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F54")]
	[Address(RVA = "0x15AE130", Offset = "0x15AE130", VA = "0x15AE130")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
