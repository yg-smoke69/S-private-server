using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002285")]
public class MVPSceneManager : MonoBehaviour
{
	[Token(Token = "0x400D81C")]
	[FieldOffset(Offset = "0xC")]
	public Camera MainCamera;

	[Token(Token = "0x400D81D")]
	[FieldOffset(Offset = "0x10")]
	public GameObject Scene;

	[Token(Token = "0x600BD50")]
	[Address(RVA = "0x1531E40", Offset = "0x1531E40", VA = "0x1531E40")]
	public MVPSceneManager()
	{
	}

	[Token(Token = "0x600BD51")]
	[Address(RVA = "0x1531E48", Offset = "0x1531E48", VA = "0x1531E48")]
	private void Awake()
	{
	}

	[Token(Token = "0x600BD52")]
	[Address(RVA = "0x1531EE8", Offset = "0x1531EE8", VA = "0x1531EE8")]
	public void ShowAll()
	{
	}

	[Token(Token = "0x600BD53")]
	[Address(RVA = "0x1531F88", Offset = "0x1531F88", VA = "0x1531F88")]
	public void ShowScene()
	{
	}

	[Token(Token = "0x600BD54")]
	[Address(RVA = "0x1532004", Offset = "0x1532004", VA = "0x1532004")]
	public void ShowCam()
	{
	}

	[Token(Token = "0x600BD55")]
	[Address(RVA = "0x1532080", Offset = "0x1532080", VA = "0x1532080")]
	public void HideScene()
	{
	}
}
