using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200382B")]
public class UILinkActivityPVEConfirmPopWindowView : UIBaseView
{
	[Token(Token = "0x4016E6A")]
	[FieldOffset(Offset = "0x14")]
	public UILabel TitleLabel;

	[Token(Token = "0x4016E6B")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ConfrimBtn;

	[Token(Token = "0x6016C2C")]
	[Address(RVA = "0x2554FFC", Offset = "0x2554FFC", VA = "0x2554FFC")]
	public UILinkActivityPVEConfirmPopWindowView()
	{
	}

	[Token(Token = "0x6016C2D")]
	[Address(RVA = "0x2555004", Offset = "0x2555004", VA = "0x2555004", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C2E")]
	[Address(RVA = "0x255520C", Offset = "0x255520C", VA = "0x255520C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
