using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033DC")]
public class UIAvatarSuitListView : UIBaseView
{
	[Token(Token = "0x4013EC7")]
	[FieldOffset(Offset = "0x14")]
	public UIEasyList SuitList;

	[Token(Token = "0x4013EC8")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ResetButton;

	[Token(Token = "0x6015F4A")]
	[Address(RVA = "0x2FA4B38", Offset = "0x2FA4B38", VA = "0x2FA4B38")]
	public UIAvatarSuitListView()
	{
	}

	[Token(Token = "0x6015F4B")]
	[Address(RVA = "0x2FA4B40", Offset = "0x2FA4B40", VA = "0x2FA4B40", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F4C")]
	[Address(RVA = "0x2FA4D48", Offset = "0x2FA4D48", VA = "0x2FA4D48")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
