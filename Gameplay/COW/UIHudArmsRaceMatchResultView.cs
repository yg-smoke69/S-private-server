using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035D4")]
public class UIHudArmsRaceMatchResultView : UIBaseView
{
	[Token(Token = "0x40158C8")]
	[FieldOffset(Offset = "0x14")]
	public GameObject CallSignContainer;

	[Token(Token = "0x40158C9")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnShare;

	[Token(Token = "0x40158CA")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnNext;

	[Token(Token = "0x40158CB")]
	[FieldOffset(Offset = "0x20")]
	public UIEasyList EasyList;

	[Token(Token = "0x601652A")]
	[Address(RVA = "0x1706F98", Offset = "0x1706F98", VA = "0x1706F98")]
	public UIHudArmsRaceMatchResultView()
	{
	}

	[Token(Token = "0x601652B")]
	[Address(RVA = "0x1706FA0", Offset = "0x1706FA0", VA = "0x1706FA0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601652C")]
	[Address(RVA = "0x170725C", Offset = "0x170725C", VA = "0x170725C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
