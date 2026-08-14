using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003421")]
public class UIChampionshipTeamMemberItemView : UIBaseView
{
	[Token(Token = "0x4014218")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Item;

	[Token(Token = "0x4014219")]
	[FieldOffset(Offset = "0x18")]
	public Transform BaseProfile;

	[Token(Token = "0x401421A")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel State;

	[Token(Token = "0x401421B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Captain;

	[Token(Token = "0x401421C")]
	[FieldOffset(Offset = "0x24")]
	public UISprite bg;

	[Token(Token = "0x6016017")]
	[Address(RVA = "0x2618B54", Offset = "0x2618B54", VA = "0x2618B54")]
	public UIChampionshipTeamMemberItemView()
	{
	}

	[Token(Token = "0x6016018")]
	[Address(RVA = "0x2618B5C", Offset = "0x2618B5C", VA = "0x2618B5C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016019")]
	[Address(RVA = "0x2618E50", Offset = "0x2618E50", VA = "0x2618E50")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
