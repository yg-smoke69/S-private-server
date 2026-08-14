using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2004110")]
public class ClipCompnent : MonoBehaviour
{
	[Token(Token = "0x401B53D")]
	[FieldOffset(Offset = "0xC")]
	public List<SetPanelClip> clips;

	[Token(Token = "0x601A917")]
	[Address(RVA = "0x3086250", Offset = "0x3086250", VA = "0x3086250")]
	public ClipCompnent()
	{
	}
}
