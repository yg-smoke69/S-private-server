using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003838")]
public class UILobbyAdItemView : UIBaseView
{
	[Token(Token = "0x4016EE3")]
	[FieldOffset(Offset = "0x14")]
	public GameObject img1;

	[Token(Token = "0x4016EE4")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x4016EE5")]
	[FieldOffset(Offset = "0x1C")]
	public UICountDownLabel CountDownLabel;

	[Token(Token = "0x4016EE6")]
	[FieldOffset(Offset = "0x20")]
	public UISprite bg;

	[Token(Token = "0x6016C53")]
	[Address(RVA = "0x216625C", Offset = "0x216625C", VA = "0x216625C")]
	public UILobbyAdItemView()
	{
	}

	[Token(Token = "0x6016C54")]
	[Address(RVA = "0x2166264", Offset = "0x2166264", VA = "0x2166264", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C55")]
	[Address(RVA = "0x2166520", Offset = "0x2166520", VA = "0x2166520")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
