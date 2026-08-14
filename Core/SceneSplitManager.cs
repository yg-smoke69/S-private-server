using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D1D")]
public class SceneSplitManager : MonoBehaviour
{
	[Token(Token = "0x4019EE4")]
	[FieldOffset(Offset = "0xC")]
	public string sceneName;

	[Token(Token = "0x4019EE5")]
	[FieldOffset(Offset = "0x10")]
	public Color color;

	[Token(Token = "0x4019EE6")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 position;

	[Token(Token = "0x4019EE7")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 size;

	[Token(Token = "0x601876E")]
	[Address(RVA = "0x21C3C3C", Offset = "0x21C3C3C", VA = "0x21C3C3C")]
	public SceneSplitManager()
	{
	}

	[Token(Token = "0x601876F")]
	[Address(RVA = "0x21C3C9C", Offset = "0x21C3C9C", VA = "0x21C3C9C")]
	private void Start()
	{
	}

	[Token(Token = "0x6018770")]
	[Address(RVA = "0x21C3CA0", Offset = "0x21C3CA0", VA = "0x21C3CA0")]
	private void OnDrawGizmosSelected()
	{
	}
}
