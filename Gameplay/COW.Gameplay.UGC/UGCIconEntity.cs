using Il2CppDummyDll;
using UnityEngine;

namespace COW.Gameplay.UGC;

[Token(Token = "0x2000C39")]
public class UGCIconEntity : MonoBehaviour
{
	[Token(Token = "0x40064CB")]
	[FieldOffset(Offset = "0xC")]
	private UISprite m_sprite;

	[Token(Token = "0x40064CC")]
	[FieldOffset(Offset = "0x10")]
	private UGCPrettySprite3DSize m_autoSize;

	[Token(Token = "0x40064CD")]
	[FieldOffset(Offset = "0x14")]
	private PresentIconEntity m_entityComm;

	[Token(Token = "0x40064CE")]
	[FieldOffset(Offset = "0x18")]
	private string m_entityID;

	[Token(Token = "0x40064CF")]
	[FieldOffset(Offset = "0x0")]
	private static UIAtlas m_noZAtlas;

	[Token(Token = "0x40064D0")]
	[FieldOffset(Offset = "0x4")]
	private static UIAtlas m_zAtlas;

	[Token(Token = "0x40064D1")]
	[FieldOffset(Offset = "0x8")]
	private static Material m_noZMaterial;

	[Token(Token = "0x40064D2")]
	[FieldOffset(Offset = "0xC")]
	private static Material m_zMaterial;

	[Token(Token = "0x6005D62")]
	[Address(RVA = "0x2583794", Offset = "0x2583794", VA = "0x2583794")]
	public UGCIconEntity()
	{
	}

	[Token(Token = "0x6005D63")]
	[Address(RVA = "0x258379C", Offset = "0x258379C", VA = "0x258379C")]
	private void OnColorChanged(int valueOld, int valueNew)
	{
	}

	[Token(Token = "0x6005D64")]
	[Address(RVA = "0x2583878", Offset = "0x2583878", VA = "0x2583878")]
	private void OnScaleChanged(float valueOld, float valueNew)
	{
	}

	[Token(Token = "0x6005D65")]
	[Address(RVA = "0x2583910", Offset = "0x2583910", VA = "0x2583910")]
	private void OnOffsetChanged(Vector3 valueOld, Vector3 valueNew)
	{
	}

	[Token(Token = "0x6005D66")]
	[Address(RVA = "0x2583A04", Offset = "0x2583A04", VA = "0x2583A04")]
	public Material GetNoZMaterial()
	{
		return null;
	}

	[Token(Token = "0x6005D67")]
	[Address(RVA = "0x2583CB0", Offset = "0x2583CB0", VA = "0x2583CB0")]
	private UIAtlas GetNoZAtlas()
	{
		return null;
	}

	[Token(Token = "0x6005D68")]
	[Address(RVA = "0x2583E80", Offset = "0x2583E80", VA = "0x2583E80")]
	private void OnIgnoreDepthChanged(bool valueOld, bool valueNew)
	{
	}

	[Token(Token = "0x6005D69")]
	[Address(RVA = "0x2583F88", Offset = "0x2583F88", VA = "0x2583F88")]
	private void OnAlwaysInScreenChanged(bool valueOld, bool valueNew)
	{
	}

	[Token(Token = "0x6005D6A")]
	[Address(RVA = "0x2584018", Offset = "0x2584018", VA = "0x2584018")]
	private void OnIconTypeChanged(string valueOld, string valueNew)
	{
	}

	[Token(Token = "0x6005D6B")]
	[Address(RVA = "0x2584328", Offset = "0x2584328", VA = "0x2584328")]
	private void OnFollowTargetChanged(string valueOld, string valueNew)
	{
	}

	[Token(Token = "0x6005D6C")]
	[Address(RVA = "0x25844A0", Offset = "0x25844A0", VA = "0x25844A0")]
	public static UGCIconEntity Create(UIPanel iconPanel, string entityID)
	{
		return null;
	}

	[Token(Token = "0x6005D6D")]
	[Address(RVA = "0x258511C", Offset = "0x258511C", VA = "0x258511C")]
	private void OnDestroy()
	{
	}
}
