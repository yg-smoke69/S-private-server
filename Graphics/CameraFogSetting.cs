using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003F25")]
public class CameraFogSetting : MonoBehaviour
{
	[Token(Token = "0x401AA13")]
	[FieldOffset(Offset = "0xC")]
	public bool needFog;

	[Token(Token = "0x401AA14")]
	[FieldOffset(Offset = "0xD")]
	private bool doWeHaveFogInScene;

	[Token(Token = "0x6019B51")]
	[Address(RVA = "0x2309634", Offset = "0x2309634", VA = "0x2309634")]
	public CameraFogSetting()
	{
	}

	[Token(Token = "0x6019B52")]
	[Address(RVA = "0x230963C", Offset = "0x230963C", VA = "0x230963C")]
	private void OnPreRender()
	{
	}

	[Token(Token = "0x6019B53")]
	[Address(RVA = "0x2309668", Offset = "0x2309668", VA = "0x2309668")]
	private void OnPostRender()
	{
	}
}
