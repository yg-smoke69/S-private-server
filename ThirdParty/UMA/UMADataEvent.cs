using System;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CD7")]
public class UMADataEvent : UnityEvent<UMAData>
{
	[Token(Token = "0x60185A0")]
	[Address(RVA = "0x2DF8B0C", Offset = "0x2DF8B0C", VA = "0x2DF8B0C")]
	public UMADataEvent()
	{
	}

	[Token(Token = "0x60185A1")]
	[Address(RVA = "0x2DFE0FC", Offset = "0x2DFE0FC", VA = "0x2DFE0FC")]
	public UMADataEvent(UMADataEvent source)
	{
	}
}
