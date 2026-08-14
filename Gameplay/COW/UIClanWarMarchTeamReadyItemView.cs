using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003460")]
public class UIClanWarMarchTeamReadyItemView : UIBaseView
{
	[Token(Token = "0x401456F")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ProfileContent;

	[Token(Token = "0x4014570")]
	[FieldOffset(Offset = "0x18")]
	public GameObject PreparedMark;

	[Token(Token = "0x4014571")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject NotPreparedMask;

	[Token(Token = "0x60160D4")]
	[Address(RVA = "0x28FD520", Offset = "0x28FD520", VA = "0x28FD520")]
	public UIClanWarMarchTeamReadyItemView()
	{
	}

	[Token(Token = "0x60160D5")]
	[Address(RVA = "0x28FD528", Offset = "0x28FD528", VA = "0x28FD528", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160D6")]
	[Address(RVA = "0x28FD76C", Offset = "0x28FD76C", VA = "0x28FD76C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
