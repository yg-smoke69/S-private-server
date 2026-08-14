using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033E0")]
public class UIAwakenLimitAvatarView : UIBaseView
{
	[Token(Token = "0x4013EDC")]
	[FieldOffset(Offset = "0x14")]
	public UIButton CloseBtn;

	[Token(Token = "0x4013EDD")]
	[FieldOffset(Offset = "0x18")]
	public UIButton GotoBtn;

	[Token(Token = "0x6015F56")]
	[Address(RVA = "0x13FED80", Offset = "0x13FED80", VA = "0x13FED80")]
	public UIAwakenLimitAvatarView()
	{
	}

	[Token(Token = "0x6015F57")]
	[Address(RVA = "0x13FED88", Offset = "0x13FED88", VA = "0x13FED88", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F58")]
	[Address(RVA = "0x13FEF90", Offset = "0x13FEF90", VA = "0x13FEF90")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
