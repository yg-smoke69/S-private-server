using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003865")]
public class UIMailReportReasonItemView : UIBaseView
{
	[Token(Token = "0x4017268")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BG;

	[Token(Token = "0x4017269")]
	[FieldOffset(Offset = "0x18")]
	public GameObject SubReasonGrid;

	[Token(Token = "0x401726A")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel SubReasonLabelTemp;

	[Token(Token = "0x6016CDA")]
	[Address(RVA = "0x18E43E8", Offset = "0x18E43E8", VA = "0x18E43E8")]
	public UIMailReportReasonItemView()
	{
	}

	[Token(Token = "0x6016CDB")]
	[Address(RVA = "0x18E43F0", Offset = "0x18E43F0", VA = "0x18E43F0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CDC")]
	[Address(RVA = "0x18E464C", Offset = "0x18E464C", VA = "0x18E464C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
