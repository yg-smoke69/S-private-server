using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035F7")]
public class UIHUDBountyRepairProgressView : UIBaseView
{
	[Token(Token = "0x40159B8")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Label_Percent;

	[Token(Token = "0x40159B9")]
	[FieldOffset(Offset = "0x18")]
	public UIProgressBar ProgressBar;

	[Token(Token = "0x40159BA")]
	[FieldOffset(Offset = "0x1C")]
	public Transform LightLineEffect;

	[Token(Token = "0x6016593")]
	[Address(RVA = "0x1675664", Offset = "0x1675664", VA = "0x1675664")]
	public UIHUDBountyRepairProgressView()
	{
	}

	[Token(Token = "0x6016594")]
	[Address(RVA = "0x167566C", Offset = "0x167566C", VA = "0x167566C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016595")]
	[Address(RVA = "0x1675810", Offset = "0x1675810", VA = "0x1675810")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
