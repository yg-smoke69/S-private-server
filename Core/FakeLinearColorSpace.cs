using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

[Token(Token = "0x2003F4E")]
public class FakeLinearColorSpace : MonoBehaviour
{
	[Token(Token = "0x401AAF7")]
	[FieldOffset(Offset = "0xC")]
	public bool m_OpenFakeLinearColorSpace;

	[Token(Token = "0x401AAF8")]
	[FieldOffset(Offset = "0x10")]
	public Light m_MainLight;

	[Token(Token = "0x401AAF9")]
	[FieldOffset(Offset = "0x14")]
	public Color m_MainLightColor;

	[NonSerialized]
	[Token(Token = "0x401AAFA")]
	[FieldOffset(Offset = "0x24")]
	public bool m_IsLinear;

	[Token(Token = "0x401AAFB")]
	[FieldOffset(Offset = "0x25")]
	private bool m_bAmbientProcessed;

	[Token(Token = "0x6019C72")]
	[Address(RVA = "0x26AC058", Offset = "0x26AC058", VA = "0x26AC058")]
	public FakeLinearColorSpace()
	{
	}

	[Token(Token = "0x6019C73")]
	[Address(RVA = "0x26AC0A4", Offset = "0x26AC0A4", VA = "0x26AC0A4")]
	public void ProcessFakeLinearColorSpace(bool start, bool open)
	{
	}

	[Token(Token = "0x6019C74")]
	[Address(RVA = "0x26AC244", Offset = "0x26AC244", VA = "0x26AC244")]
	private void ProcessDirectionalLight()
	{
	}

	[Token(Token = "0x6019C75")]
	[Address(RVA = "0x26AC3D8", Offset = "0x26AC3D8", VA = "0x26AC3D8")]
	public void ProcessAmbient()
	{
	}

	[Token(Token = "0x6019C76")]
	[Address(RVA = "0x26AC504", Offset = "0x26AC504", VA = "0x26AC504")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6019C77")]
	[Address(RVA = "0x26AC5B8", Offset = "0x26AC5B8", VA = "0x26AC5B8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6019C78")]
	[Address(RVA = "0x26AC664", Offset = "0x26AC664", VA = "0x26AC664")]
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x6019C79")]
	[Address(RVA = "0x26AC67C", Offset = "0x26AC67C", VA = "0x26AC67C")]
	public static void UpdateSkyboxAmbient()
	{
	}

	[Token(Token = "0x6019C7A")]
	[Address(RVA = "0x26AC6F0", Offset = "0x26AC6F0", VA = "0x26AC6F0")]
	public void UpdateMainLightColor()
	{
	}
}
