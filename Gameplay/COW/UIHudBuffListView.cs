using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035FE")]
public class UIHudBuffListView : UIBaseView
{
	[Token(Token = "0x40159CF")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid ItemListGrid;

	[Token(Token = "0x40159D0")]
	[FieldOffset(Offset = "0x18")]
	public Transform ItemListGridTF;

	[Token(Token = "0x60165A8")]
	[Address(RVA = "0x1EFC21C", Offset = "0x1EFC21C", VA = "0x1EFC21C")]
	public UIHudBuffListView()
	{
	}

	[Token(Token = "0x60165A9")]
	[Address(RVA = "0x1EFC224", Offset = "0x1EFC224", VA = "0x1EFC224", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165AA")]
	[Address(RVA = "0x1EFC404", Offset = "0x1EFC404", VA = "0x1EFC404")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
