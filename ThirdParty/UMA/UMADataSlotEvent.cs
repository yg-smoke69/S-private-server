using System;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CD8")]
public class UMADataSlotEvent : UnityEvent<UMAData, SlotData>
{
	[Token(Token = "0x60185A2")]
	[Address(RVA = "0x2DFE2F4", Offset = "0x2DFE2F4", VA = "0x2DFE2F4")]
	public UMADataSlotEvent()
	{
	}

	[Token(Token = "0x60185A3")]
	[Address(RVA = "0x2DFE358", Offset = "0x2DFE358", VA = "0x2DFE358")]
	public UMADataSlotEvent(UMADataSlotEvent source)
	{
	}
}
