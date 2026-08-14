using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036EC")]
public class UIHUDPVEAutoReviveInfoView : UIBaseView
{
	[Token(Token = "0x401631B")]
	[FieldOffset(Offset = "0x14")]
	public GameObject SingleRevive;

	[Token(Token = "0x401631C")]
	[FieldOffset(Offset = "0x18")]
	public GameObject TeamRevive;

	[Token(Token = "0x401631D")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel ReviveCountDown;

	[Token(Token = "0x601686F")]
	[Address(RVA = "0x1680C14", Offset = "0x1680C14", VA = "0x1680C14")]
	public UIHUDPVEAutoReviveInfoView()
	{
	}

	[Token(Token = "0x6016870")]
	[Address(RVA = "0x1680C1C", Offset = "0x1680C1C", VA = "0x1680C1C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016871")]
	[Address(RVA = "0x1680E6C", Offset = "0x1680E6C", VA = "0x1680E6C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
