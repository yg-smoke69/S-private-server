using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003382")]
public class HUDPVEMissionCenterTipView : UIBaseView
{
	[Token(Token = "0x40139ED")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Container;

	[Token(Token = "0x40139EE")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ContentLabel;

	[Token(Token = "0x6015E3D")]
	[Address(RVA = "0x1909C08", Offset = "0x1909C08", VA = "0x1909C08")]
	public HUDPVEMissionCenterTipView()
	{
	}

	[Token(Token = "0x6015E3E")]
	[Address(RVA = "0x1909C10", Offset = "0x1909C10", VA = "0x1909C10", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E3F")]
	[Address(RVA = "0x1909E0C", Offset = "0x1909E0C", VA = "0x1909E0C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
