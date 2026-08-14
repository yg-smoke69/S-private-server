using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003506")]
public class UIElitePassLobbyIconView : UIBaseView
{
	[Token(Token = "0x4014E31")]
	[FieldOffset(Offset = "0x14")]
	public GameObject EP;

	[Token(Token = "0x4014E32")]
	[FieldOffset(Offset = "0x18")]
	public GameObject EPNewGO;

	[Token(Token = "0x4014E33")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnEP;

	[Token(Token = "0x4014E34")]
	[FieldOffset(Offset = "0x20")]
	public UISprite LobbyEPIcon;

	[Token(Token = "0x60162C2")]
	[Address(RVA = "0x304BCD0", Offset = "0x304BCD0", VA = "0x304BCD0")]
	public UIElitePassLobbyIconView()
	{
	}

	[Token(Token = "0x60162C3")]
	[Address(RVA = "0x304BCD8", Offset = "0x304BCD8", VA = "0x304BCD8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162C4")]
	[Address(RVA = "0x304BF88", Offset = "0x304BF88", VA = "0x304BF88")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
