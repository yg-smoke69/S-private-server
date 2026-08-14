using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CD9")]
public class UMADataSlotMaterialRectEvent : UnityEvent<UMAData, SlotData, Material, Rect>
{
	[Token(Token = "0x60185A4")]
	[Address(RVA = "0x2DFE5C4", Offset = "0x2DFE5C4", VA = "0x2DFE5C4")]
	public UMADataSlotMaterialRectEvent()
	{
	}

	[Token(Token = "0x60185A5")]
	[Address(RVA = "0x2DFE628", Offset = "0x2DFE628", VA = "0x2DFE628")]
	public UMADataSlotMaterialRectEvent(UMADataSlotMaterialRectEvent source)
	{
	}
}
