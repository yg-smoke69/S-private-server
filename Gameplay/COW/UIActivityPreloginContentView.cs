using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033B0")]
public class UIActivityPreloginContentView : UIBaseView
{
	[Token(Token = "0x4013BC9")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ScrollView_NoTabs;

	[Token(Token = "0x4013BCA")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ScrollView;

	[Token(Token = "0x4013BCB")]
	[FieldOffset(Offset = "0x1C")]
	public UITable ContentTable;

	[Token(Token = "0x4013BCC")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid DetailList;

	[Token(Token = "0x4013BCD")]
	[FieldOffset(Offset = "0x24")]
	public ActivityPreloginDescription AwardDescTemplate;

	[Token(Token = "0x4013BCE")]
	[FieldOffset(Offset = "0x28")]
	public UIDragScrollView DragArea;

	[Token(Token = "0x6015EC6")]
	[Address(RVA = "0x2FBE66C", Offset = "0x2FBE66C", VA = "0x2FBE66C")]
	public UIActivityPreloginContentView()
	{
	}

	[Token(Token = "0x6015EC7")]
	[Address(RVA = "0x2FBE674", Offset = "0x2FBE674", VA = "0x2FBE674", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EC8")]
	[Address(RVA = "0x2FBE9E4", Offset = "0x2FBE9E4", VA = "0x2FBE9E4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
