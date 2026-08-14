using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003F95")]
public class NetworkMaterialHelper : MonoBehaviour
{
	[Token(Token = "0x401ACA4")]
	[FieldOffset(Offset = "0xC")]
	public Vector2 TextureSize;

	[Token(Token = "0x401ACA5")]
	[FieldOffset(Offset = "0x14")]
	public string[] TargetMaterialNameList;

	[Token(Token = "0x401ACA6")]
	[FieldOffset(Offset = "0x18")]
	public ENetworkMaterialGroup m_NetWorkMaterialGroup;

	[Token(Token = "0x401ACA7")]
	[FieldOffset(Offset = "0x1C")]
	public bool m_IsDynamic;

	[Token(Token = "0x401ACA8")]
	private const string REGEX_MAT_END = "\\s*\\(.*\\)?$";

	[Token(Token = "0x6019DFA")]
	[Address(RVA = "0x2979064", Offset = "0x2979064", VA = "0x2979064")]
	public NetworkMaterialHelper()
	{
	}

	[Token(Token = "0x6019DFB")]
	[Address(RVA = "0x29790C0", Offset = "0x29790C0", VA = "0x29790C0")]
	private void Start()
	{
	}
}
