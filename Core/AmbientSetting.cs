using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003F1A")]
public class AmbientSetting : MonoBehaviour
{
	[Token(Token = "0x401A9EF")]
	[FieldOffset(Offset = "0xC")]
	public Color ambientColor;

	[Token(Token = "0x401A9F0")]
	[FieldOffset(Offset = "0x1C")]
	private Color _orginalColor;

	[Token(Token = "0x6019B0C")]
	[Address(RVA = "0x2EC3B30", Offset = "0x2EC3B30", VA = "0x2EC3B30")]
	public AmbientSetting()
	{
	}

	[Token(Token = "0x6019B0D")]
	[Address(RVA = "0x2EC3B38", Offset = "0x2EC3B38", VA = "0x2EC3B38")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6019B0E")]
	[Address(RVA = "0x2EC3B84", Offset = "0x2EC3B84", VA = "0x2EC3B84")]
	private void OnDisable()
	{
	}
}
