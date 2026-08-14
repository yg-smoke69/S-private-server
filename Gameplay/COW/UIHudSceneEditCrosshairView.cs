using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003729")]
public class UIHudSceneEditCrosshairView : UIBaseView
{
	[Token(Token = "0x40164CA")]
	[FieldOffset(Offset = "0x14")]
	public GameObject NormalContainer;

	[Token(Token = "0x40164CB")]
	[FieldOffset(Offset = "0x18")]
	public GameObject DeleteContainer;

	[Token(Token = "0x40164CC")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite DeleteIcon;

	[Token(Token = "0x6016926")]
	[Address(RVA = "0x1C5B858", Offset = "0x1C5B858", VA = "0x1C5B858")]
	public UIHudSceneEditCrosshairView()
	{
	}

	[Token(Token = "0x6016927")]
	[Address(RVA = "0x1C5B860", Offset = "0x1C5B860", VA = "0x1C5B860", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016928")]
	[Address(RVA = "0x1C5BAB0", Offset = "0x1C5BAB0", VA = "0x1C5BAB0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
