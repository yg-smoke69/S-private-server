using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003766")]
public class UIHudTaskNameIconView : UIBaseView
{
	[Token(Token = "0x40166A6")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Normal;

	[Token(Token = "0x40166A7")]
	[FieldOffset(Offset = "0x18")]
	public UISprite SpriteNormal;

	[Token(Token = "0x40166A8")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Emergency;

	[Token(Token = "0x60169DD")]
	[Address(RVA = "0x1792424", Offset = "0x1792424", VA = "0x1792424")]
	public UIHudTaskNameIconView()
	{
	}

	[Token(Token = "0x60169DE")]
	[Address(RVA = "0x179242C", Offset = "0x179242C", VA = "0x179242C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169DF")]
	[Address(RVA = "0x179267C", Offset = "0x179267C", VA = "0x179267C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
