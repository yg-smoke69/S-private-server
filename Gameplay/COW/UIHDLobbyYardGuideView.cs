using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035BC")]
public class UIHDLobbyYardGuideView : UIBaseView
{
	[Token(Token = "0x401581D")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel MainPanel;

	[Token(Token = "0x401581E")]
	[FieldOffset(Offset = "0x18")]
	public GameObject VisualControlObject_Right;

	[Token(Token = "0x60164E2")]
	[Address(RVA = "0x20342F0", Offset = "0x20342F0", VA = "0x20342F0")]
	public UIHDLobbyYardGuideView()
	{
	}

	[Token(Token = "0x60164E3")]
	[Address(RVA = "0x20342F8", Offset = "0x20342F8", VA = "0x20342F8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164E4")]
	[Address(RVA = "0x20344F4", Offset = "0x20344F4", VA = "0x20344F4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
