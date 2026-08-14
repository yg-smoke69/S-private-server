using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003EB0")]
public class ReflectionTrigger : MonoBehaviour
{
	[Token(Token = "0x401A795")]
	[FieldOffset(Offset = "0xC")]
	public CameraReflection.ReflectDistrict district;

	[Token(Token = "0x401A796")]
	[FieldOffset(Offset = "0x10")]
	public float horizonY;

	[Token(Token = "0x401A797")]
	[FieldOffset(Offset = "0x14")]
	private CameraReflection reflection;

	[Token(Token = "0x60197F8")]
	[Address(RVA = "0x316B680", Offset = "0x316B680", VA = "0x316B680")]
	public ReflectionTrigger()
	{
	}

	[Token(Token = "0x60197F9")]
	[Address(RVA = "0x316B688", Offset = "0x316B688", VA = "0x316B688")]
	private void Start()
	{
	}

	[Token(Token = "0x60197FA")]
	[Address(RVA = "0x316B70C", Offset = "0x316B70C", VA = "0x316B70C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60197FB")]
	[Address(RVA = "0x316B8F8", Offset = "0x316B8F8", VA = "0x316B8F8")]
	private void OnTriggerExit(Collider other)
	{
	}
}
