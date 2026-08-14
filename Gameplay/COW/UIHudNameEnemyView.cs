using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036BA")]
public class UIHudNameEnemyView : UIBaseView
{
	[Token(Token = "0x40160F6")]
	[FieldOffset(Offset = "0x14")]
	public GameObject AdditiveInfo;

	[Token(Token = "0x40160F7")]
	[FieldOffset(Offset = "0x18")]
	public UISprite AdditiveIcon;

	[Token(Token = "0x40160F8")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel AdditiveLabel;

	[Token(Token = "0x60167DB")]
	[Address(RVA = "0x1F50698", Offset = "0x1F50698", VA = "0x1F50698")]
	public UIHudNameEnemyView()
	{
	}

	[Token(Token = "0x60167DC")]
	[Address(RVA = "0x1F506A0", Offset = "0x1F506A0", VA = "0x1F506A0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167DD")]
	[Address(RVA = "0x1F508FC", Offset = "0x1F508FC", VA = "0x1F508FC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
