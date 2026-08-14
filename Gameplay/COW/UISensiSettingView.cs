using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039AA")]
public class UISensiSettingView : UIBaseView
{
	[Token(Token = "0x401834F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ResetDefaultBtn;

	[Token(Token = "0x4018350")]
	[FieldOffset(Offset = "0x18")]
	public UITable Table;

	[Token(Token = "0x60170A5")]
	[Address(RVA = "0x1A531D0", Offset = "0x1A531D0", VA = "0x1A531D0")]
	public UISensiSettingView()
	{
	}

	[Token(Token = "0x60170A6")]
	[Address(RVA = "0x1A531D8", Offset = "0x1A531D8", VA = "0x1A531D8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170A7")]
	[Address(RVA = "0x1A533E0", Offset = "0x1A533E0", VA = "0x1A533E0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
