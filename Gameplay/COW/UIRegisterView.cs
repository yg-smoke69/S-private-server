using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003949")]
public class UIRegisterView : UIBaseView
{
	[Token(Token = "0x4017FB4")]
	[FieldOffset(Offset = "0x14")]
	public Animation AnimSwitch;

	[Token(Token = "0x4017FB5")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelMiddle;

	[Token(Token = "0x4017FB6")]
	[FieldOffset(Offset = "0x1C")]
	public TypewriterEffect TypewriterEffect1;

	[Token(Token = "0x4017FB7")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelBottom;

	[Token(Token = "0x4017FB8")]
	[FieldOffset(Offset = "0x24")]
	public TypewriterEffect TypewriterEffect2;

	[Token(Token = "0x4017FB9")]
	[FieldOffset(Offset = "0x28")]
	public GameObject GoMask;

	[Token(Token = "0x4017FBA")]
	[FieldOffset(Offset = "0x2C")]
	public Transform TransformContentHide;

	[Token(Token = "0x4017FBB")]
	[FieldOffset(Offset = "0x30")]
	public Transform TrRegisterContent;

	[Token(Token = "0x4017FBC")]
	[FieldOffset(Offset = "0x34")]
	public GameObject GoBtnClose;

	[Token(Token = "0x4017FBD")]
	[FieldOffset(Offset = "0x38")]
	public UIButton BtnClose;

	[Token(Token = "0x6016F82")]
	[Address(RVA = "0x1E453FC", Offset = "0x1E453FC", VA = "0x1E453FC")]
	public UIRegisterView()
	{
	}

	[Token(Token = "0x6016F83")]
	[Address(RVA = "0x1E45404", Offset = "0x1E45404", VA = "0x1E45404", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F84")]
	[Address(RVA = "0x1E458A4", Offset = "0x1E458A4", VA = "0x1E458A4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
