using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000CAB")]
public class UIComponentsController : MonoBehaviour
{
	[Token(Token = "0x2000CAC")]
	public enum ComponentsType
	{
		[Token(Token = "0x4006754")]
		Outline = 1,
		[Token(Token = "0x4006755")]
		Shadow
	}

	[Token(Token = "0x4006751")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<int, Type> controllerMaps;

	[Token(Token = "0x4006752")]
	[FieldOffset(Offset = "0x10")]
	private ComponentsType toDisabled;

	[Token(Token = "0x600607D")]
	[Address(RVA = "0x1EBE0E4", Offset = "0x1EBE0E4", VA = "0x1EBE0E4")]
	public UIComponentsController()
	{
	}

	[Token(Token = "0x600607E")]
	[Address(RVA = "0x1EBE240", Offset = "0x1EBE240", VA = "0x1EBE240")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600607F")]
	[Address(RVA = "0x1EBE6E8", Offset = "0x1EBE6E8", VA = "0x1EBE6E8")]
	public void SetFlag(ComponentsType ct)
	{
	}
}
