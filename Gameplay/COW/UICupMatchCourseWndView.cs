using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003496")]
public class UICupMatchCourseWndView : UIBaseView
{
	[Token(Token = "0x4014825")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Win;

	[Token(Token = "0x4014826")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Lose;

	[Token(Token = "0x4014827")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject LoseToChallenge;

	[Token(Token = "0x4014828")]
	[FieldOffset(Offset = "0x20")]
	public Transform Course;

	[Token(Token = "0x4014829")]
	[FieldOffset(Offset = "0x24")]
	public UIButton MaskBtn;

	[Token(Token = "0x401482A")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Next;

	[Token(Token = "0x6016176")]
	[Address(RVA = "0x274F2A4", Offset = "0x274F2A4", VA = "0x274F2A4")]
	public UICupMatchCourseWndView()
	{
	}

	[Token(Token = "0x6016177")]
	[Address(RVA = "0x274F2AC", Offset = "0x274F2AC", VA = "0x274F2AC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016178")]
	[Address(RVA = "0x274F5E8", Offset = "0x274F5E8", VA = "0x274F5E8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
