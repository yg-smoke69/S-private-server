using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace COW;

[Serializable]
[Token(Token = "0x2000BDB")]
public class ColorChangedEvent : UnityEvent<Color>
{
	[Token(Token = "0x60059D8")]
	[Address(RVA = "0x17374DC", Offset = "0x17374DC", VA = "0x17374DC")]
	public ColorChangedEvent()
	{
	}
}
