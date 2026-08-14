using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003505")]
public class UIElitePassLobbyIconCyberwaspView : UIBaseView
{
	[Token(Token = "0x4014E2D")]
	[FieldOffset(Offset = "0x14")]
	public GameObject EP;

	[Token(Token = "0x4014E2E")]
	[FieldOffset(Offset = "0x18")]
	public GameObject EPNewGO;

	[Token(Token = "0x4014E2F")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnEP;

	[Token(Token = "0x4014E30")]
	[FieldOffset(Offset = "0x20")]
	public UISprite LobbyEPIcon;

	[Token(Token = "0x60162BF")]
	[Address(RVA = "0x304BA10", Offset = "0x304BA10", VA = "0x304BA10")]
	public UIElitePassLobbyIconCyberwaspView()
	{
	}

	[Token(Token = "0x60162C0")]
	[Address(RVA = "0x304BA18", Offset = "0x304BA18", VA = "0x304BA18", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162C1")]
	[Address(RVA = "0x304BCC8", Offset = "0x304BCC8", VA = "0x304BCC8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
