using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A3C")]
public class UIUGCHudWidgetInspectorView : UIBaseView
{
	[Token(Token = "0x401896C")]
	[FieldOffset(Offset = "0x14")]
	public UIButton SwitchBtn;

	[Token(Token = "0x401896D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject BG;

	[Token(Token = "0x401896E")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView ScrollView;

	[Token(Token = "0x401896F")]
	[FieldOffset(Offset = "0x20")]
	public UITable Table;

	[Token(Token = "0x4018970")]
	[FieldOffset(Offset = "0x24")]
	public GameObject NameAttribute;

	[Token(Token = "0x4018971")]
	[FieldOffset(Offset = "0x28")]
	public UISprite Icon;

	[Token(Token = "0x4018972")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Name;

	[Token(Token = "0x4018973")]
	[FieldOffset(Offset = "0x30")]
	public UILabel TextAttribute;

	[Token(Token = "0x4018974")]
	[FieldOffset(Offset = "0x34")]
	public UILabel ImageAttribute;

	[Token(Token = "0x4018975")]
	[FieldOffset(Offset = "0x38")]
	public UILabel ButtonAttribute;

	[Token(Token = "0x4018976")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel TransformAttribute;

	[Token(Token = "0x4018977")]
	[FieldOffset(Offset = "0x40")]
	public UIButton EditBtn;

	[Token(Token = "0x4018978")]
	[FieldOffset(Offset = "0x44")]
	public UIWidget Container;

	[Token(Token = "0x4018979")]
	[FieldOffset(Offset = "0x48")]
	public Transform ZEnd;

	[Token(Token = "0x601725A")]
	[Address(RVA = "0x2775860", Offset = "0x2775860", VA = "0x2775860")]
	public UIUGCHudWidgetInspectorView()
	{
	}

	[Token(Token = "0x601725B")]
	[Address(RVA = "0x2775868", Offset = "0x2775868", VA = "0x2775868", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601725C")]
	[Address(RVA = "0x2775EB0", Offset = "0x2775EB0", VA = "0x2775EB0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
