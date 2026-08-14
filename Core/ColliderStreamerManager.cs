using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D12")]
public class ColliderStreamerManager : MonoBehaviour
{
	[Token(Token = "0x4019E9C")]
	[FieldOffset(Offset = "0xC")]
	public Transform player;

	[Token(Token = "0x4019E9D")]
	[FieldOffset(Offset = "0x10")]
	public bool spawnedPlayer;

	[Token(Token = "0x4019E9E")]
	[FieldOffset(Offset = "0x14")]
	public string playerTag;

	[Token(Token = "0x4019E9F")]
	[FieldOffset(Offset = "0x0")]
	public static string COLLIDERSTREAMERMANAGERTAG;

	[Token(Token = "0x4019EA0")]
	[FieldOffset(Offset = "0x18")]
	public List<ColliderStreamer> colliderStreamers;

	[Token(Token = "0x601874C")]
	[Address(RVA = "0x230FAFC", Offset = "0x230FAFC", VA = "0x230FAFC")]
	public ColliderStreamerManager()
	{
	}

	[Token(Token = "0x601874D")]
	[Address(RVA = "0x230F718", Offset = "0x230F718", VA = "0x230F718")]
	public void AddColliderStreamer(ColliderStreamer colliderStreamer)
	{
	}

	[Token(Token = "0x601874E")]
	[Address(RVA = "0x230F300", Offset = "0x230F300", VA = "0x230F300")]
	public void AddColliderScene(ColliderScene colliderScene)
	{
	}

	[Token(Token = "0x601874F")]
	[Address(RVA = "0x230FB68", Offset = "0x230FB68", VA = "0x230FB68")]
	public void Update()
	{
	}
}
