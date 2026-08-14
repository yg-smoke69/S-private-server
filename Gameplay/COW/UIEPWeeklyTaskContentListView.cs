using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003524")]
public class UIEPWeeklyTaskContentListView : UIBaseView
{
	[Token(Token = "0x4014FA1")]
	[FieldOffset(Offset = "0x14")]
	public UICenterOnChild CenterChild;

	[Token(Token = "0x4014FA2")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4014FA3")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid Grid;

	[Token(Token = "0x4014FA4")]
	[FieldOffset(Offset = "0x20")]
	public UIButton LeftBtn;

	[Token(Token = "0x4014FA5")]
	[FieldOffset(Offset = "0x24")]
	public UIButton RightBtn;

	[Token(Token = "0x4014FA6")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnClose;

	[Token(Token = "0x601631C")]
	[Address(RVA = "0x2BB7D5C", Offset = "0x2BB7D5C", VA = "0x2BB7D5C")]
	public UIEPWeeklyTaskContentListView()
	{
	}

	[Token(Token = "0x601631D")]
	[Address(RVA = "0x2BB7D64", Offset = "0x2BB7D64", VA = "0x2BB7D64", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601631E")]
	[Address(RVA = "0x2BB80EC", Offset = "0x2BB80EC", VA = "0x2BB80EC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
