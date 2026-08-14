using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003532")]
public class UIFFWS03LobbyEntranceView : UIBaseView
{
	[Token(Token = "0x4015045")]
	[FieldOffset(Offset = "0x14")]
	public GameObject RewardTip;

	[Token(Token = "0x4015046")]
	[FieldOffset(Offset = "0x18")]
	public GameObject LivingTip;

	[Token(Token = "0x6016346")]
	[Address(RVA = "0x19EBC90", Offset = "0x19EBC90", VA = "0x19EBC90")]
	public UIFFWS03LobbyEntranceView()
	{
	}

	[Token(Token = "0x6016347")]
	[Address(RVA = "0x19EBC98", Offset = "0x19EBC98", VA = "0x19EBC98", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016348")]
	[Address(RVA = "0x19EBE88", Offset = "0x19EBE88", VA = "0x19EBE88")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
