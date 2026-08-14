using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200367B")]
public class UIHudIntroCutsceneView : UIBaseView
{
	[Token(Token = "0x4015E25")]
	[FieldOffset(Offset = "0x14")]
	public UILabel myTeamName;

	[Token(Token = "0x4015E26")]
	[FieldOffset(Offset = "0x18")]
	public UILabel myTeamDesc;

	[Token(Token = "0x4015E27")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject myTeamIcon_1;

	[Token(Token = "0x4015E28")]
	[FieldOffset(Offset = "0x20")]
	public GameObject myTeamIcon_2;

	[Token(Token = "0x4015E29")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LocalPlayerName;

	[Token(Token = "0x4015E2A")]
	[FieldOffset(Offset = "0x28")]
	public UILabel TeammateName_1;

	[Token(Token = "0x4015E2B")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel TeammateName_2;

	[Token(Token = "0x4015E2C")]
	[FieldOffset(Offset = "0x30")]
	public UILabel TeammateName_3;

	[Token(Token = "0x601671E")]
	[Address(RVA = "0x22A9B4C", Offset = "0x22A9B4C", VA = "0x22A9B4C")]
	public UIHudIntroCutsceneView()
	{
	}

	[Token(Token = "0x601671F")]
	[Address(RVA = "0x22A9B54", Offset = "0x22A9B54", VA = "0x22A9B54", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016720")]
	[Address(RVA = "0x22A9F84", Offset = "0x22A9F84", VA = "0x22A9F84")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
