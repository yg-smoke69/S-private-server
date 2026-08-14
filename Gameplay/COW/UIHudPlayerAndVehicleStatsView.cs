using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036E0")]
public class UIHudPlayerAndVehicleStatsView : UIBaseView
{
	[Token(Token = "0x401628E")]
	[FieldOffset(Offset = "0x14")]
	public Transform ArmorStats;

	[Token(Token = "0x401628F")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Mark;

	[Token(Token = "0x4016290")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid Skills;

	[Token(Token = "0x4016291")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SkillTemplate;

	[Token(Token = "0x4016292")]
	[FieldOffset(Offset = "0x24")]
	public UISprite HPBar;

	[Token(Token = "0x4016293")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelHP;

	[Token(Token = "0x4016294")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite VehicleHPBarThumb;

	[Token(Token = "0x4016295")]
	[FieldOffset(Offset = "0x30")]
	public UISprite VehicleHPBar;

	[Token(Token = "0x4016296")]
	[FieldOffset(Offset = "0x34")]
	public UILabel LabelVehicleHP;

	[Token(Token = "0x4016297")]
	[FieldOffset(Offset = "0x38")]
	public UIGrid BuffNode;

	[Token(Token = "0x4016298")]
	[FieldOffset(Offset = "0x3C")]
	public UIGrid UseSkillNode;

	[Token(Token = "0x601684B")]
	[Address(RVA = "0x1861504", Offset = "0x1861504", VA = "0x1861504")]
	public UIHudPlayerAndVehicleStatsView()
	{
	}

	[Token(Token = "0x601684C")]
	[Address(RVA = "0x186150C", Offset = "0x186150C", VA = "0x186150C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601684D")]
	[Address(RVA = "0x1861A4C", Offset = "0x1861A4C", VA = "0x1861A4C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
