using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200393C")]
public class UIQuickMessageCustomItemView : UIBaseView
{
	[Token(Token = "0x4017F36")]
	[FieldOffset(Offset = "0x14")]
	public UILabel MessageContent;

	[Token(Token = "0x4017F37")]
	[FieldOffset(Offset = "0x18")]
	public UIButton DeleteBtn;

	[Token(Token = "0x6016F5B")]
	[Address(RVA = "0x1AC28EC", Offset = "0x1AC28EC", VA = "0x1AC28EC")]
	public UIQuickMessageCustomItemView()
	{
	}

	[Token(Token = "0x6016F5C")]
	[Address(RVA = "0x1AC28F4", Offset = "0x1AC28F4", VA = "0x1AC28F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F5D")]
	[Address(RVA = "0x1AC2AFC", Offset = "0x1AC2AFC", VA = "0x1AC2AFC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
