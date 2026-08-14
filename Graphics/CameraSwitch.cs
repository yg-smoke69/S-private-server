using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D0F")]
public class CameraSwitch : MonoBehaviour
{
	[Token(Token = "0x4019E91")]
	[FieldOffset(Offset = "0xC")]
	public GameObject[] objects;

	[Token(Token = "0x4019E92")]
	[FieldOffset(Offset = "0x10")]
	public UILabel text;

	[Token(Token = "0x4019E93")]
	[FieldOffset(Offset = "0x14")]
	private int m_CurrentActiveObject;

	[Token(Token = "0x6018741")]
	[Address(RVA = "0x230CD30", Offset = "0x230CD30", VA = "0x230CD30")]
	public CameraSwitch()
	{
	}

	[Token(Token = "0x6018742")]
	[Address(RVA = "0x230CD38", Offset = "0x230CD38", VA = "0x230CD38")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6018743")]
	[Address(RVA = "0x230CDC4", Offset = "0x230CDC4", VA = "0x230CDC4")]
	public void NextCamera()
	{
	}
}
