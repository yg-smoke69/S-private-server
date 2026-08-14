using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036ED")]
public class UIHudPVEBossHPView : UIBaseView
{
	[Token(Token = "0x401631E")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Container;

	[Token(Token = "0x401631F")]
	[FieldOffset(Offset = "0x18")]
	public UISprite HPbarfg;

	[Token(Token = "0x4016320")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite HPbarbg;

	[Token(Token = "0x4016321")]
	[FieldOffset(Offset = "0x20")]
	public UILabel HPLayerCount;

	[Token(Token = "0x6016872")]
	[Address(RVA = "0x183A898", Offset = "0x183A898", VA = "0x183A898")]
	public UIHudPVEBossHPView()
	{
	}

	[Token(Token = "0x6016873")]
	[Address(RVA = "0x183A8A0", Offset = "0x183A8A0", VA = "0x183A8A0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016874")]
	[Address(RVA = "0x183AB5C", Offset = "0x183AB5C", VA = "0x183AB5C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
