using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036B9")]
public class UIHudNameBattleFlagView : UIBaseView
{
	[Token(Token = "0x40160F5")]
	[FieldOffset(Offset = "0x14")]
	public UILabel NameLabel;

	[Token(Token = "0x60167D8")]
	[Address(RVA = "0x1F504E0", Offset = "0x1F504E0", VA = "0x1F504E0")]
	public UIHudNameBattleFlagView()
	{
	}

	[Token(Token = "0x60167D9")]
	[Address(RVA = "0x1F504E8", Offset = "0x1F504E8", VA = "0x1F504E8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167DA")]
	[Address(RVA = "0x1F50690", Offset = "0x1F50690", VA = "0x1F50690")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
