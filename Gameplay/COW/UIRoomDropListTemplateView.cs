using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003961")]
public class UIRoomDropListTemplateView : UIBaseView
{
	[Token(Token = "0x4018041")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Title;

	[Token(Token = "0x4018042")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget DropListTemplatePopMenu;

	[Token(Token = "0x6016FCA")]
	[Address(RVA = "0x23BE0C8", Offset = "0x23BE0C8", VA = "0x23BE0C8")]
	public UIRoomDropListTemplateView()
	{
	}

	[Token(Token = "0x6016FCB")]
	[Address(RVA = "0x23BE0D0", Offset = "0x23BE0D0", VA = "0x23BE0D0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FCC")]
	[Address(RVA = "0x23BE2D8", Offset = "0x23BE2D8", VA = "0x23BE2D8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
