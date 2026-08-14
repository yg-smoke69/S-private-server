using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003412")]
public class UIChampionshipLobbyView : UIBaseView
{
	[Token(Token = "0x40141B9")]
	[FieldOffset(Offset = "0x14")]
	public UIButton RuleBtn;

	[Token(Token = "0x40141BA")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid EntranceContainer;

	[Token(Token = "0x6015FEA")]
	[Address(RVA = "0x2830FD0", Offset = "0x2830FD0", VA = "0x2830FD0")]
	public UIChampionshipLobbyView()
	{
	}

	[Token(Token = "0x6015FEB")]
	[Address(RVA = "0x2830FD8", Offset = "0x2830FD8", VA = "0x2830FD8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FEC")]
	[Address(RVA = "0x28311E0", Offset = "0x28311E0", VA = "0x28311E0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
