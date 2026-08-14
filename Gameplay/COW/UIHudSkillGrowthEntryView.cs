using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003751")]
public class UIHudSkillGrowthEntryView : UIBaseView
{
	[Token(Token = "0x4016620")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnEntry;

	[Token(Token = "0x4016621")]
	[FieldOffset(Offset = "0x18")]
	public UILabel SkillTokenCnt;

	[Token(Token = "0x601699E")]
	[Address(RVA = "0x16C6330", Offset = "0x16C6330", VA = "0x16C6330")]
	public UIHudSkillGrowthEntryView()
	{
	}

	[Token(Token = "0x601699F")]
	[Address(RVA = "0x16C6338", Offset = "0x16C6338", VA = "0x16C6338", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169A0")]
	[Address(RVA = "0x16C6540", Offset = "0x16C6540", VA = "0x16C6540")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
