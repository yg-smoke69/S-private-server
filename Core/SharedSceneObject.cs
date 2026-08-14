using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003FE3")]
public class SharedSceneObject : MonoBehaviour
{
	[Token(Token = "0x401AE7B")]
	[FieldOffset(Offset = "0xC")]
	public int key;

	[Token(Token = "0x401AE7C")]
	[FieldOffset(Offset = "0x10")]
	public bool isMain;

	[Token(Token = "0x401AE7D")]
	[FieldOffset(Offset = "0x14")]
	public GameObject sceneObject;

	[Token(Token = "0x401AE7E")]
	[FieldOffset(Offset = "0x18")]
	public int[] lightmapIndexList;

	[Token(Token = "0x601A021")]
	[Address(RVA = "0x21C5B54", Offset = "0x21C5B54", VA = "0x21C5B54")]
	public SharedSceneObject()
	{
	}

	[Token(Token = "0x601A022")]
	[Address(RVA = "0x21C5B5C", Offset = "0x21C5B5C", VA = "0x21C5B5C")]
	private void Awake()
	{
	}

	[Token(Token = "0x601A023")]
	[Address(RVA = "0x21C5DF8", Offset = "0x21C5DF8", VA = "0x21C5DF8")]
	private void OnDestroy()
	{
	}
}
