using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003659")]
public class UIHudFriendaddView : UIBaseView
{
	[Token(Token = "0x4015D07")]
	[FieldOffset(Offset = "0x14")]
	public Transform ProfileContainer;

	[Token(Token = "0x4015D08")]
	[FieldOffset(Offset = "0x18")]
	public UIButton AddFriendBtn;

	[Token(Token = "0x4015D09")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject AddIcon;

	[Token(Token = "0x4015D0A")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SendedIcon;

	[Token(Token = "0x4015D0B")]
	[FieldOffset(Offset = "0x24")]
	public GameObject FriendIcon;

	[Token(Token = "0x60166B8")]
	[Address(RVA = "0x1886908", Offset = "0x1886908", VA = "0x1886908")]
	public UIHudFriendaddView()
	{
	}

	[Token(Token = "0x60166B9")]
	[Address(RVA = "0x1886910", Offset = "0x1886910", VA = "0x1886910", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60166BA")]
	[Address(RVA = "0x1886BEC", Offset = "0x1886BEC", VA = "0x1886BEC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
