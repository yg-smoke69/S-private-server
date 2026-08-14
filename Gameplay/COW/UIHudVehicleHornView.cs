using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037C2")]
public class UIHudVehicleHornView : UIBaseView
{
	[Token(Token = "0x401696D")]
	[FieldOffset(Offset = "0x14")]
	public UIButton btn;

	[Token(Token = "0x401696E")]
	[FieldOffset(Offset = "0x18")]
	public UISprite icon;

	[Token(Token = "0x401696F")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite normal;

	[Token(Token = "0x6016AF1")]
	[Address(RVA = "0x1A6DD2C", Offset = "0x1A6DD2C", VA = "0x1A6DD2C")]
	public UIHudVehicleHornView()
	{
	}

	[Token(Token = "0x6016AF2")]
	[Address(RVA = "0x1A6DD34", Offset = "0x1A6DD34", VA = "0x1A6DD34", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016AF3")]
	[Address(RVA = "0x1A6DF9C", Offset = "0x1A6DF9C", VA = "0x1A6DF9C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
