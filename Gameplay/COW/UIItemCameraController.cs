using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20028E9")]
internal class UIItemCameraController : MonoBehaviour
{
	[Token(Token = "0x400FB9D")]
	[FieldOffset(Offset = "0xC")]
	private Camera m_Camera;

	[Token(Token = "0x601029B")]
	[Address(RVA = "0x1ADE920", Offset = "0x1ADE920", VA = "0x1ADE920")]
	public UIItemCameraController()
	{
	}

	[Token(Token = "0x601029C")]
	[Address(RVA = "0x1ADE928", Offset = "0x1ADE928", VA = "0x1ADE928")]
	private void Awake()
	{
	}

	[Token(Token = "0x601029D")]
	[Address(RVA = "0x1ADEA98", Offset = "0x1ADEA98", VA = "0x1ADEA98")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x601029E")]
	[Address(RVA = "0x1ADEBEC", Offset = "0x1ADEBEC", VA = "0x1ADEBEC")]
	private void OnItemCameraStateChange(object[] data)
	{
	}
}
