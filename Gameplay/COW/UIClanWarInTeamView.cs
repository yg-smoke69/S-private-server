using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200345B")]
public class UIClanWarInTeamView : UIBaseView
{
	[Token(Token = "0x401454E")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Top;

	[Token(Token = "0x401454F")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ReturnBtn;

	[Token(Token = "0x60160C5")]
	[Address(RVA = "0x2B4F60C", Offset = "0x2B4F60C", VA = "0x2B4F60C")]
	public UIClanWarInTeamView()
	{
	}

	[Token(Token = "0x60160C6")]
	[Address(RVA = "0x2B4F614", Offset = "0x2B4F614", VA = "0x2B4F614", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160C7")]
	[Address(RVA = "0x2B4F810", Offset = "0x2B4F810", VA = "0x2B4F810")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
