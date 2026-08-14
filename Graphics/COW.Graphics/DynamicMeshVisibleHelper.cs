using Il2CppDummyDll;
using UnityEngine;

namespace COW.Graphics;

[Token(Token = "0x2003F4C")]
public class DynamicMeshVisibleHelper : MonoBehaviour
{
	[Token(Token = "0x401AAF5")]
	[FieldOffset(Offset = "0xC")]
	public string[] ShowWithType;

	[Token(Token = "0x6019C6D")]
	[Address(RVA = "0x25A86A8", Offset = "0x25A86A8", VA = "0x25A86A8")]
	public DynamicMeshVisibleHelper()
	{
	}

	[Token(Token = "0x6019C6E")]
	[Address(RVA = "0x25A86B0", Offset = "0x25A86B0", VA = "0x25A86B0")]
	public bool NeedShowWithType()
	{
		return default(bool);
	}
}
