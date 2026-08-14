using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003414")]
public class UIChampionshipNoticeDotView : UIBaseView
{
	[Token(Token = "0x40141CA")]
	[FieldOffset(Offset = "0x14")]
	public GameObject dotEnable;

	[Token(Token = "0x40141CB")]
	[FieldOffset(Offset = "0x18")]
	public GameObject dotDisable;

	[Token(Token = "0x6015FF0")]
	[Address(RVA = "0x2834B30", Offset = "0x2834B30", VA = "0x2834B30")]
	public UIChampionshipNoticeDotView()
	{
	}

	[Token(Token = "0x6015FF1")]
	[Address(RVA = "0x2834B38", Offset = "0x2834B38", VA = "0x2834B38", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FF2")]
	[Address(RVA = "0x2834D28", Offset = "0x2834D28", VA = "0x2834D28")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
