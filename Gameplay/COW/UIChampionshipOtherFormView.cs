using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003417")]
public class UIChampionshipOtherFormView : UIBaseView
{
	[Token(Token = "0x40141D5")]
	[FieldOffset(Offset = "0x14")]
	public Transform LeftTabContainer;

	[Token(Token = "0x40141D6")]
	[FieldOffset(Offset = "0x18")]
	public GameObject TeamPage;

	[Token(Token = "0x6015FF9")]
	[Address(RVA = "0x28364DC", Offset = "0x28364DC", VA = "0x28364DC")]
	public UIChampionshipOtherFormView()
	{
	}

	[Token(Token = "0x6015FFA")]
	[Address(RVA = "0x28364E4", Offset = "0x28364E4", VA = "0x28364E4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FFB")]
	[Address(RVA = "0x28366B8", Offset = "0x28366B8", VA = "0x28366B8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
