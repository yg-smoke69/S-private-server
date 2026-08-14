using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200383D")]
public class UILobbyDotView : UIBaseView
{
	[Token(Token = "0x4016F23")]
	[FieldOffset(Offset = "0x14")]
	public GameObject dotEnable;

	[Token(Token = "0x4016F24")]
	[FieldOffset(Offset = "0x18")]
	public GameObject dotDisable;

	[Token(Token = "0x6016C62")]
	[Address(RVA = "0xD9E1FC", Offset = "0xD9E1FC", VA = "0xD9E1FC")]
	public UILobbyDotView()
	{
	}

	[Token(Token = "0x6016C63")]
	[Address(RVA = "0xD9E204", Offset = "0xD9E204", VA = "0xD9E204", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C64")]
	[Address(RVA = "0xD9E3F4", Offset = "0xD9E3F4", VA = "0xD9E3F4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
