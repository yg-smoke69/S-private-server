using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003EAE")]
public class ReflectionObject : MonoBehaviour
{
	[Token(Token = "0x401A790")]
	[FieldOffset(Offset = "0xC")]
	public CameraReflection.ReflectDistrict district;

	[Token(Token = "0x401A791")]
	[FieldOffset(Offset = "0x10")]
	private bool isInitialized;

	[Token(Token = "0x401A792")]
	[FieldOffset(Offset = "0x14")]
	private CameraReflection m_reflection;

	[Token(Token = "0x60197EE")]
	[Address(RVA = "0x3326378", Offset = "0x3326378", VA = "0x3326378")]
	public ReflectionObject()
	{
	}

	[Token(Token = "0x60197EF")]
	[Address(RVA = "0x3326380", Offset = "0x3326380", VA = "0x3326380")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60197F0")]
	[Address(RVA = "0x3326504", Offset = "0x3326504", VA = "0x3326504")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60197F1")]
	[Address(RVA = "0x3326384", Offset = "0x3326384", VA = "0x3326384")]
	private void Initialize()
	{
	}

	[Token(Token = "0x60197F2")]
	[Address(RVA = "0x3326508", Offset = "0x3326508", VA = "0x3326508")]
	private void Cleanup()
	{
	}
}
