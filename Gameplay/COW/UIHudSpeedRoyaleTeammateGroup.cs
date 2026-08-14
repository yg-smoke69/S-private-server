using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D41")]
internal class UIHudSpeedRoyaleTeammateGroup : MonoBehaviour
{
	[Token(Token = "0x40114E6")]
	[FieldOffset(Offset = "0xC")]
	public UIGrid Grid;

	[Token(Token = "0x40114E7")]
	[FieldOffset(Offset = "0x10")]
	public UISprite VehicleHpSprite;

	[Token(Token = "0x40114E8")]
	[FieldOffset(Offset = "0x14")]
	public Dictionary<IHAAMHPPLMG, UIHudSpeedRoyaleTeammateItem> TeammateItems;

	[Token(Token = "0x6012EF5")]
	[Address(RVA = "0x1FDF494", Offset = "0x1FDF494", VA = "0x1FDF494")]
	public UIHudSpeedRoyaleTeammateGroup()
	{
	}

	[Token(Token = "0x6012EF6")]
	[Address(RVA = "0x1FDF520", Offset = "0x1FDF520", VA = "0x1FDF520")]
	public void InitInfo(Vehicle v)
	{
	}

	[Token(Token = "0x6012EF7")]
	[Address(RVA = "0x1FDF5BC", Offset = "0x1FDF5BC", VA = "0x1FDF5BC")]
	public void OnVehicleHPChanged(Vehicle v)
	{
	}
}
