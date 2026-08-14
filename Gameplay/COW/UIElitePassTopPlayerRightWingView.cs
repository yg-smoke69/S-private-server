using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200350F")]
public class UIElitePassTopPlayerRightWingView : UIBaseView
{
	[Token(Token = "0x4014EE8")]
	[FieldOffset(Offset = "0x14")]
	public UISprite EPIcon;

	[Token(Token = "0x4014EE9")]
	[FieldOffset(Offset = "0x18")]
	public UILabel BadgeCount;

	[Token(Token = "0x60162DD")]
	[Address(RVA = "0x30699C0", Offset = "0x30699C0", VA = "0x30699C0")]
	public UIElitePassTopPlayerRightWingView()
	{
	}

	[Token(Token = "0x60162DE")]
	[Address(RVA = "0x30699C8", Offset = "0x30699C8", VA = "0x30699C8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162DF")]
	[Address(RVA = "0x3069BD0", Offset = "0x3069BD0", VA = "0x3069BD0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
