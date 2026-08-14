using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D15")]
public class NonStreamPreview : MonoBehaviour, _Attribute
{
	[Token(Token = "0x4019EA8")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<string, GameObject> previewGameObjects;

	[Token(Token = "0x6018754")]
	[Address(RVA = "0x1C73870", Offset = "0x1C73870", VA = "0x1C73870")]
	public NonStreamPreview()
	{
	}

	[Token(Token = "0x6018755")]
	[Address(RVA = "0x1C738FC", Offset = "0x1C738FC", VA = "0x1C738FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6018756")]
	[Address(RVA = "0x1C73D1C", Offset = "0x1C73D1C", VA = "0x1C73D1C", Slot = "4")]
	public void OriginLoaded(string previewName)
	{
	}

	[Token(Token = "0x6018757")]
	[Address(RVA = "0x1C73E24", Offset = "0x1C73E24", VA = "0x1C73E24", Slot = "5")]
	public void OriginUnloaded(string previewName)
	{
	}
}
