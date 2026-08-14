using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200352B")]
public class UIEscortTutorialView : UIBaseView
{
	[Token(Token = "0x4014FF7")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnClose;

	[Token(Token = "0x4014FF8")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x4014FF9")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject GoDots;

	[Token(Token = "0x4014FFA")]
	[FieldOffset(Offset = "0x20")]
	public Transform TrDots;

	[Token(Token = "0x4014FFB")]
	[FieldOffset(Offset = "0x24")]
	public GameObject GoWrap;

	[Token(Token = "0x4014FFC")]
	[FieldOffset(Offset = "0x28")]
	public Transform TrWrap;

	[Token(Token = "0x4014FFD")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel IntroTitle;

	[Token(Token = "0x4014FFE")]
	[FieldOffset(Offset = "0x30")]
	public UIButton Left;

	[Token(Token = "0x4014FFF")]
	[FieldOffset(Offset = "0x34")]
	public UIButton Right;

	[Token(Token = "0x6016331")]
	[Address(RVA = "0x19DD030", Offset = "0x19DD030", VA = "0x19DD030")]
	public UIEscortTutorialView()
	{
	}

	[Token(Token = "0x6016332")]
	[Address(RVA = "0x19DD038", Offset = "0x19DD038", VA = "0x19DD038", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016333")]
	[Address(RVA = "0x19DD478", Offset = "0x19DD478", VA = "0x19DD478")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
