using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200361B")]
public class UIHudCreepView : UIBaseView
{
	[Token(Token = "0x4015A7F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnCreep;

	[Token(Token = "0x4015A80")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BGCreep;

	[Token(Token = "0x4015A81")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite CreepSprite;

	[Token(Token = "0x4015A82")]
	[FieldOffset(Offset = "0x20")]
	public UISprite HightlightSpr;

	[Token(Token = "0x6016600")]
	[Address(RVA = "0x1369964", Offset = "0x1369964", VA = "0x1369964")]
	public UIHudCreepView()
	{
	}

	[Token(Token = "0x6016601")]
	[Address(RVA = "0x136996C", Offset = "0x136996C", VA = "0x136996C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016602")]
	[Address(RVA = "0x1369C34", Offset = "0x1369C34", VA = "0x1369C34")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
