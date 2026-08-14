using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E28")]
public class AkInitializer : MonoBehaviour
{
	[Token(Token = "0x401A52C")]
	[FieldOffset(Offset = "0x0")]
	private static AkInitializer ms_Instance;

	[Token(Token = "0x401A52D")]
	[FieldOffset(Offset = "0xC")]
	public AkWwiseInitializationSettings InitializationSettings;

	[Token(Token = "0x6019447")]
	[Address(RVA = "0x36B0E10", Offset = "0x36B0E10", VA = "0x36B0E10")]
	public AkInitializer()
	{
	}

	[Token(Token = "0x6019448")]
	[Address(RVA = "0x36B0E18", Offset = "0x36B0E18", VA = "0x36B0E18")]
	private void Awake()
	{
	}

	[Token(Token = "0x6019449")]
	[Address(RVA = "0x36B0F48", Offset = "0x36B0F48", VA = "0x36B0F48")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x601944A")]
	[Address(RVA = "0x36B1054", Offset = "0x36B1054", VA = "0x36B1054")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x601944B")]
	[Address(RVA = "0x36B1124", Offset = "0x36B1124", VA = "0x36B1124")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x601944C")]
	[Address(RVA = "0x36B11E8", Offset = "0x36B11E8", VA = "0x36B11E8")]
	private void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x601944D")]
	[Address(RVA = "0x36B12C0", Offset = "0x36B12C0", VA = "0x36B12C0")]
	private void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x601944E")]
	[Address(RVA = "0x36B1398", Offset = "0x36B1398", VA = "0x36B1398")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x601944F")]
	[Address(RVA = "0x36B1468", Offset = "0x36B1468", VA = "0x36B1468")]
	private void LateUpdate()
	{
	}
}
