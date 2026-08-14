using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Gameplay;

[Serializable]
[Token(Token = "0x20003EC")]
public class ClipEvents
{
	[Token(Token = "0x40039B8")]
	[FieldOffset(Offset = "0x8")]
	public AnimationClip m_Clip;

	[Token(Token = "0x40039B9")]
	[FieldOffset(Offset = "0xC")]
	public List<ClipEvent> m_Events;

	[Token(Token = "0x6001268")]
	[Address(RVA = "0x24A26E4", Offset = "0x24A26E4", VA = "0x24A26E4")]
	public ClipEvents()
	{
	}
}
